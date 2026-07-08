using STSS.Core.Rules;

namespace STSS.Core.Foundation.UnitTests.Rules;

public sealed class UrlRulesTests
{
    [Theory]
    [InlineData("https://struttontechnologies.com")]
    [InlineData("http://example.com")]
    public void IsValid_ReturnsTrue_ForValidUrl(string value)
    {
        Assert.True(UrlRules.IsValidAbsoluteHttpUrl(value));
    }

    [Theory]
    [InlineData("")]
    [InlineData("not-a-url")]
    [InlineData("ftp://example.com")]
    public void IsValid_ReturnsFalse_ForInvalidUrl(string value)
    {
        Assert.False(UrlRules.IsValidAbsoluteHttpUrl(value));
    }
}
