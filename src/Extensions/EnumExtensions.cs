namespace GameMode.Common;

/// <summary>
/// Provides extension methods for working with enumeration values.
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Gets the value of the <see cref="DescriptionAttribute"/>
    /// applied to the specified enum value.
    /// </summary>
    /// <typeparam name="TEnum">
    /// The type of the enumeration.
    /// </typeparam>
    /// <param name="value">
    /// The enum value whose description should be retrieved.
    /// </param>
    /// <returns>
    /// The description defined by the <see cref="DescriptionAttribute"/>.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Thrown when the enum value does not define a
    /// <see cref="DescriptionAttribute"/>.
    /// </exception>
    public static string GetDescription<TEnum>(this TEnum value)
        where TEnum : struct, Enum
    {
        FieldInfo field = typeof(TEnum).GetField(value.ToString());
        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description
            ?? throw new InvalidOperationException(
                $"Enum value '{value}' is missing a {nameof(DescriptionAttribute)}.");
    }
}
