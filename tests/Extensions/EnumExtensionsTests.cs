namespace GameMode.Common.Tests.Extensions;

public class EnumExtensions
{
    [Test]
    public void GetDescription_WhenEnumValueHasDescription_ShouldReturnDescription()
    {
        // Act
        string description = TestEnum.First.GetDescription();

        // Assert
        description.Should().Be("First Value");
    }

    [Test]
    public void GetDescription_WhenEnumValueHasNoDescription_ShouldThrowInvalidOperationException()
    {
        // Act
        Action action = () => TestEnum.Second.GetDescription();

        // Assert
        action.Should()
            .Throw<InvalidOperationException>()
            .WithMessage(
                $"Enum value '{TestEnum.Second}' is missing a {nameof(System.ComponentModel.DescriptionAttribute)}.");
    }
}
