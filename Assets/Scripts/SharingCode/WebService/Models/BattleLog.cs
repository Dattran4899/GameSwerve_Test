using MechSharingCode.WebService.Interface;
using System.Collections.Generic;

namespace MechSharingCode.WebService.BattleLogs
{
    public class BattleLog
    {
        public string UserId { get; set; }
        public long LogTime { get; set; }
        public string BattleId { get; set; }
        public string Player2Id { get; set; }
        public string WinnerId { get; set; }
    }
    public class BattleLogCollection : IHttpResponseData
    {
        public List<BattleLog> BattleLogs { get; set; }
    }
}
