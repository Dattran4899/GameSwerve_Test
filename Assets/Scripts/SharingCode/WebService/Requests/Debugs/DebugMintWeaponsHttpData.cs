

namespace MechSharingCode.WebService.Requests.Debugs
{
    using System.Collections.Generic;
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;
    using Sirenix.OdinInspector;

    public static class DebugMintWeaponsApiCode
    {
        public const int WeaponsNotExist = 1;
        public const int FailedToSync = 2;
    }

    [HttpRequestDefinition("debug/user/weapons/mint")]
    public class DebugMintWeaponsRequestData : IHttpRequestData
    {
        [Required]
        public List<int> WeaponIds { get; set; } = new();
    }

    public class DebugMintWeaponsResponseData : IHttpResponseData
    {
    }
}
