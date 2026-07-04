namespace GameMode.Common;

/// <summary>
/// Represents a weapon available in GTA: San Andreas.
/// </summary>
public interface IWeapon
{
    /// <summary>
    /// Represents an unlimited amount of ammunition.
    /// </summary>
    const int UnlimitedAmmo = 99999999;

    /// <summary>
    /// Gets the underlying game weapon identifier.
    /// </summary>
    Weapon Id { get; }

    /// <summary>
    /// Gets the display name of the weapon.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the weapon slot.
    /// </summary>
    int Slot { get; }
}
