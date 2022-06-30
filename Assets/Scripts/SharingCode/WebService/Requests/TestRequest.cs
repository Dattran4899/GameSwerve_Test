namespace MechSharingCode.WebService.Test
{
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    [HttpRequestDefinition("test")]
    public class TestHttpRequestData : IHttpRequestData
    {
    }
    
    public class TestHttpResponseData : IHttpResponseData
    {
    }
}