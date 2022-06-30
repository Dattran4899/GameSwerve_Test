namespace MechSharingCode.WebService.Authentication
{
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    /// <summary>Will response LoginResponseData</summary>
    [HttpRequestDefinition("otp/verify")]
    public class VerifyOtpRequestData : IHttpRequestData
    {
        public string Email { get; set; }
        public string Code { get; set; }
    }
}
