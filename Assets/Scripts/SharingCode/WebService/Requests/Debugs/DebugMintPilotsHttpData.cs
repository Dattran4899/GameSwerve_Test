namespace MechSharingCode.WebService.Requests.Debugs
{
    using System.Collections.Generic;
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;
    using Sirenix.OdinInspector;

    public static class DebugMintPilotsApiCode
    {
        public const int PilotsNotExist = 1;
        public const int FailedToSync = 2;
    }

    [HttpRequestDefinition("debug/user/pilots/mint")]
    public class DebugMintPilotsRequestData : IHttpRequestData
    {
        [Required]
        public List<int> PilotIds { get; set; } = new();
    }

    public class DebugMintPilotsResponseData : IHttpResponseData
    {
    }
}
