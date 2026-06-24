namespace GameMode.Common;

/// <summary>
/// Specifies a user-facing name for an enum value.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
public class DisplayNameAttribute(string value) : Attribute
{
    /// <summary>
    /// Gets the display name.
    /// </summary>
    public string Value { get; } = value;
}
