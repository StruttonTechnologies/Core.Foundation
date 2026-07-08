using STSS.Core.Rules;

namespace STSS.Core.Foundation.UnitTests.Rules;

public sealed class PhoneNumberRulesTests
{
    [Theory]
    [InlineData("555-555-5555")]
    [InlineData("(555) 555-5555")]
    [InlineData("5555555555")]
    public void IsValid_ReturnsTrue_ForValidPhoneNumber(string value)
    {
        Assert.True(PhoneNumberRules.IsValid(value));
    }

    [Theory]
    [InlineData("")]
    [InlineData("abc")]
    [InlineData("123")]
    public void IsValid_ReturnsFalse_ForInvalidPhoneNumber(string value)
    {
        Assert.False(PhoneNumberRules.IsValid(value));
    }
}
