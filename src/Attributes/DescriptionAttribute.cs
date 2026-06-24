namespace GameMode.Common;

/// <summary>
/// Specifies additional descriptive information for an enum value.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class DescriptionAttribute(string value) : Attribute
{
    /// <summary>
    /// Gets the description.
    /// </summary>
    public string Value { get; } = value;
}
