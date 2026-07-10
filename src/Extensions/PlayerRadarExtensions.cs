namespace GameMode.Common;

/// <summary>
/// Provides extension methods for controlling a player's visibility on the radar map.
/// </summary>
public static class PlayerRadarExtensions
{
    /// <summary>
    /// Makes the player visible on the radar map.
    /// </summary>
    /// <param name="player">
    /// The player to show on the radar.
    /// </param>
    /// <remarks>
    /// Sets the alpha component of the player's color to fully opaque
    /// while preserving the original RGB values.
    /// </remarks>
    public static void ShowOnRadarMap(this Player player)
    {
        Color color = player.Color;
        player.Color = new Color(color.R, color.G, color.B, 255f);
    }

    /// <summary>
    /// Hides the player from the radar map.
    /// </summary>
    /// <param name="player">
    /// The player to hide from the radar.
    /// </param>
    /// <remarks>
    /// Sets the alpha component of the player's color to fully transparent
    /// while preserving the original RGB values.
    /// </remarks>
    public static void HideOnRadarMap(this Player player)
    {
        Color color = player.Color;
        player.Color = new Color(color.R, color.G, color.B, 0f);
    }
}
