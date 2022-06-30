namespace MechSharingCode.WebService.Authentication
{
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    [HttpRequestDefinition("otp/send")]
    public class SendOtpRequestData : IHttpRequestData
    {
        public string Email { get; set; }
    }

    /// <summary>
    /// 0. Email is not whitedlist
    /// 1. Invalid email
    /// 2. Too many request
    /// </summary>
    public class SendOtpResponseData : IHttpResponseData
    {
        public int Status { get; set; }
        public string Code { get; set; }
    }

    public class SendOtpApiCode
    {
        public const int EmailIsNotWhitelisted = 0;
        public const int InvalidEmail = 1;
        public const int TooManyRequest = 2;
    }
}
