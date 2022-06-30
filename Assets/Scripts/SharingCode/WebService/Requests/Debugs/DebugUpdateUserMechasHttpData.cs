using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.WebService.DebugMode
{
    using Sirenix.OdinInspector;

    public class DebugUpdateUserMechasApiCode
    {
        public const int NotLinkedWalletYet = 1;
        public const int InvalidMechaIds = 2;
    }
    
    [HttpRequestDefinition("debug/user/mechas/update")]
    public class DebugUpdateUserMechasRequestData : IHttpRequestData
    {
        [Required] public List<int> MechaIds { get; set; } = new();
    }

    public class DebugUpdateUserMechasResponseData : IHttpResponseData
    {
    }
}
