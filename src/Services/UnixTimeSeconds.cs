namespace GameMode.Common;

/// <summary>
/// Provides access to the current Unix timestamp expressed in seconds.
/// </summary>
/// <remarks>
/// See <see href="https://en.wikipedia.org/wiki/Unix_time">Unix time</see>.
/// </remarks>
public class UnixTimeSeconds(TimeProvider timeProvider)
{
    /// <summary>
    /// Gets the number of seconds that have elapsed since
    /// 1970-01-01T00:00:00Z (Unix epoch).
    /// </summary>
    public long Value => timeProvider.GetUtcNow().ToUnixTimeSeconds();
}
