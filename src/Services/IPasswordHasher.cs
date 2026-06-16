namespace GameMode.Common;

public interface IPasswordHasher
{
    bool Verify(string text, string passwordHash);
    string HashPassword(string text);
}
