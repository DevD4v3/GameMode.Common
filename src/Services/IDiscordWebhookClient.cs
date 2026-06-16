namespace GameMode.Common;

/// <summary>
/// Represents a message to be sent through a Discord webhook.
/// </summary>
/// <param name="Content">
/// The message content.
/// </param>
public record DiscordMessage(string Content);

/// <summary>
/// Provides methods to send notifications through a Discord webhook.
/// </summary>
public interface IDiscordWebhookClient
{
    /// <summary>
    /// Sends a message to a Discord webhook.
    /// </summary>
    /// <param name="message">
    /// The message to send.
    /// </param>
    /// <returns>
    /// <see langword="true"/> if the message was sent successfully;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    Task<bool> SendAsync(DiscordMessage message);
}
