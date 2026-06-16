namespace GameMode.Common;

/// <summary>
/// Provides helper methods for detecting key state transitions.
/// </summary>
public static class KeyUtils
{
    /// <summary>
    /// Determines whether the specified keys were pressed.
    /// </summary>
    /// <param name="newKeys">The current key state.</param>
    /// <param name="oldKeys">The previous key state.</param>
    /// <param name="keys">The keys to evaluate.</param>
    /// <returns>
    /// <see langword="true"/> if the specified keys were pressed;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool HasPressed(Keys newKeys, Keys oldKeys, Keys keys)
        => newKeys.HasFlag(keys) && !oldKeys.HasFlag(keys);

    /// <summary>
    /// Determines whether the specified keys were released.
    /// </summary>
    /// <param name="newKeys">The current key state.</param>
    /// <param name="oldKeys">The previous key state.</param>
    /// <param name="keys">The keys to evaluate.</param>
    /// <returns>
    /// <see langword="true"/> if the specified keys were released;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    public static bool HasReleased(Keys newKeys, Keys oldKeys, Keys keys)
        => !newKeys.HasFlag(keys) && oldKeys.HasFlag(keys);
}
