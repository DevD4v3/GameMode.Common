namespace GameMode.Common;

/// <summary>
/// Provides extension methods for checking whether a player reference is valid.
/// </summary>
public static class PlayerValidationExtensions
{
    /// <summary>
    /// Determines whether the specified player reference is <see langword="null"/>.
    /// </summary>
    /// <param name="player">
    /// The player reference to check.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the player reference is <see langword="null"/>;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsInvalidPlayer(this Player player) => player is null;
}
