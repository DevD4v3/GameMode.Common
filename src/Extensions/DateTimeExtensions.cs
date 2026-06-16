namespace GameMode.Common;

/// <summary>
/// Provides extension methods for working with <see cref="DateTime"/> values.
/// </summary>
public static class DateTimeExtensions
{
    /// <summary>
    /// Converts the date to the ISO 8601 date format (<c>yyyy-MM-dd</c>).
    /// </summary>
    /// <param name="dateTime">The date to format.</param>
    /// <returns>The formatted date string.</returns>
    public static string ToIsoDateString(this DateTime dateTime)
        => dateTime.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
}
