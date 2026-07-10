namespace GameMode.Common;

/// <summary>
/// Provides extension methods for manipulating a player's score.
/// </summary>
public static class PlayerScoreExtensions
{
    /// <summary>
    /// Increments the player's score by one.
    /// </summary>
    /// <param name="player">
    /// The player whose score will be incremented.
    /// </param>
    public static void AddScore(this Player player)
        => player.Score++;

    /// <summary>
    /// Adds the specified value to the player's score.
    /// </summary>
    /// <param name="player">
    /// The player whose score will be updated.
    /// </param>
    /// <param name="value">
    /// The amount to add. Must be greater than or equal to zero.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is negative.
    /// </exception>
    public static void AddScore(this Player player, int value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value);
        player.Score += value;
    }

    /// <summary>
    /// Sets the player's score to the specified value.
    /// </summary>
    /// <param name="player">
    /// The player whose score will be updated.
    /// </param>
    /// <param name="value">
    /// The new score. Must be greater than or equal to zero.
    /// </param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when <paramref name="value"/> is negative.
    /// </exception>
    public static void SetScore(this Player player, int value)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(value);
        player.Score = value;
    }
}
