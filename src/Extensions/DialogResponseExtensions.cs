namespace GameMode.Common;

/// <summary>
/// Provides extension methods for dialog responses.
/// </summary>
public static class DialogResponseExtensions
{
    /// <summary>
    /// Determines whether the dialog was closed using the right button
    /// or the player disconnected.
    /// </summary>
    /// <param name="response">The dialog response.</param>
    /// <returns>
    /// <see langword="true"/> if the dialog was cancelled or the player
    /// disconnected; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsRightButtonOrDisconnected(this ListDialogResponse response)
        => response.Response.IsRightButtonOrDisconnected();

    /// <summary>
    /// Determines whether the dialog was closed using the right button
    /// or the player disconnected.
    /// </summary>
    /// <param name="response">The dialog response.</param>
    /// <returns>
    /// <see langword="true"/> if the dialog was cancelled or the player
    /// disconnected; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsRightButtonOrDisconnected(this TablistDialogResponse response)
        => response.Response.IsRightButtonOrDisconnected();

    /// <summary>
    /// Determines whether the dialog was closed using the right button
    /// or the player disconnected.
    /// </summary>
    /// <param name="response">The dialog response.</param>
    /// <returns>
    /// <see langword="true"/> if the dialog was cancelled or the player
    /// disconnected; otherwise, <see langword="false"/>.
    /// </returns>
    public static bool IsRightButtonOrDisconnected(this InputDialogResponse response)
        => response.Response.IsRightButtonOrDisconnected();

    private static bool IsRightButtonOrDisconnected(this DialogResponse response)
        => response == DialogResponse.RightButtonOrCancel ||
           response == DialogResponse.Disconnected;
}
