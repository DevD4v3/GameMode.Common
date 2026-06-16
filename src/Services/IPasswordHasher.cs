namespace GameMode.Common;

/// <summary>
/// Provides functionality for hashing and verifying passwords.
/// </summary>
public interface IPasswordHasher
{
    /// <summary>
    /// Verifies whether the specified text matches a password hash.
    /// </summary>
    /// <param name="text">The plain text password to verify.</param>
    /// <param name="passwordHash">The password hash to compare against.</param>
    /// <returns>
    /// <see langword="true"/> if the password matches the hash;
    /// otherwise, <see langword="false"/>.
    /// </returns>
    bool Verify(string text, string passwordHash);

    /// <summary>
    /// Creates a password hash from the specified plain text password.
    /// </summary>
    /// <param name="text">The plain text password.</param>
    /// <returns>The generated password hash.</returns>
    string HashPassword(string text);
}
