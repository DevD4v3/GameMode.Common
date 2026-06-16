namespace GameMode.Common;

/// <summary>
/// Provides extension methods for working with objects through reflection.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Sets the value of a property by name.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the object whose property value will be modified.
    /// </typeparam>
    /// <param name="object">
    /// The object whose property value will be set.
    /// </param>
    /// <param name="value">
    /// The value to assign to the property.
    /// </param>
    /// <param name="propertyName">
    /// The name of the property to modify.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// Thrown when <paramref name="object"/>, <paramref name="value"/>,
    /// or <paramref name="propertyName"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the specified property does not exist.
    /// </exception>
    public static void SetValue<T>(
        this T @object,
        object value,
        string propertyName) where T : class
    {
        ArgumentNullException.ThrowIfNull(@object);
        ArgumentNullException.ThrowIfNull(value);
        ArgumentNullException.ThrowIfNull(propertyName);
        Type type = @object.GetType();
        PropertyInfo propertyInfo = type.GetProperty(propertyName) ??
            throw new InvalidOperationException($"Property '{propertyName}' was not found in type '{type.Name}'.");

        propertyInfo.SetValue(@object, value);
    }
}
