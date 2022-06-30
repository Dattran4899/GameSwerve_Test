
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.WebService.Blueprint
{
    using MechSharingCode.Utils;
    using Sirenix.OdinInspector;

    [HttpRequestDefinition("blueprint/get")]
    public class GetBlueprintRequestData : IHttpRequestData
    {
        [Required]
        public string Version { set; get; }
    }

    public class GetBlueprintResponseData : IHttpResponseData
    {
        public string Url { set; get; }
        public string Hash { set; get; }
    }
}
