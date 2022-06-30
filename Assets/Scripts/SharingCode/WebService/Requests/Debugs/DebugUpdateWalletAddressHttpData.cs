namespace MechSharingCode.WebService.Requests.Debugs
{
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    [HttpRequestDefinition("debug/wallet/update")]
    public class DebugUpdateWalletAddressRequestData : IHttpRequestData
    {
        public string WalletAddress { get; set; }
    }

    public class DebugUpdateWalletAddressResponseData : IHttpResponseData
    {
    }
}