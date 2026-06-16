namespace GameMode.Common;

/// <summary>
/// Represents the configuration of an open.mp server.
/// </summary>
public class ServerSettings
{
    /// <summary>
    /// Gets the server hostname.
    /// </summary>
    public string HostName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the server language.
    /// </summary>
    public string LanguageText { get; init; } = string.Empty;

    /// <summary>
    /// Gets the gamemode text.
    /// </summary>
    public string GameModeText { get; init; } = string.Empty;

    /// <summary>
    /// Gets the map name.
    /// </summary>
    public string MapName { get; init; } = string.Empty;

    /// <summary>
    /// Gets the server website URL.
    /// </summary>
    public string WebUrl { get; init; } = string.Empty;
}
