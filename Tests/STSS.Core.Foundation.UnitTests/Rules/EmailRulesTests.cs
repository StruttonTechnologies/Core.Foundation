using STSS.Core.Rules;

namespace STSS.Core.Foundation.UnitTests.Rules;

public sealed class EmailRulesTests
{
    [Theory]
    [InlineData("test@example.com")]
    [InlineData("first.last@example.co")]
    [InlineData("user+tag@example.org")]
    public void IsValid_ReturnsTrue_ForValidEmail(string value)
    {
        Assert.True(EmailRules.IsValid(value));
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("not-an-email")]
    [InlineData("@example.com")]
    [InlineData("test@")]
    public void IsValid_ReturnsFalse_ForInvalidEmail(string value)
    {
        Assert.False(EmailRules.IsValid(value));
    }
}
