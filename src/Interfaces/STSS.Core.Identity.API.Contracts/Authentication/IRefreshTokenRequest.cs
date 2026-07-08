namespace STSS.Core.Identity.API.Contracts.Authentication
{
    public interface IRefreshTokenRequest
    {
        public string RefreshToken { get; }
    }
}
