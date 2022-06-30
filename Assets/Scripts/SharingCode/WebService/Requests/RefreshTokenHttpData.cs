namespace MechSharingCode.WebService.Authentication
{
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;
    
    [HttpRequestDefinition("login/refresh")]
    public class RefreshTokenRequestData : IHttpRequestData
    {
        public string RefreshToken { get; set; }
    }
    
    public class RefreshTokenResponseData : LoginResponseData
    {
    }
}
