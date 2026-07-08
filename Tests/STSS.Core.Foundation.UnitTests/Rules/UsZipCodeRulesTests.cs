using STSS.Core.Rules;

namespace STSS.Core.Foundation.UnitTests.Rules;

public sealed class UsZipCodeRulesTests
{
    [Theory]
    [InlineData("97754")]
    [InlineData("97754-1234")]
    public void IsValid_ReturnsTrue_ForValidZipCode(string value)
    {
        Assert.True(UsZipCodeRules.IsValid(value));
    }

    [Theory]
    [InlineData("")]
    [InlineData("9775")]
    [InlineData("977544")]
    [InlineData("ABCDE")]
    public void IsValid_ReturnsFalse_ForInvalidZipCode(string value)
    {
        Assert.False(UsZipCodeRules.IsValid(value));
    }
}
