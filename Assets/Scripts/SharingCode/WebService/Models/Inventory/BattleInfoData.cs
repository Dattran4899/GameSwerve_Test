using MessagePack;

namespace MechSharingCode.WebService.Inventory
{
    using System.Collections.Generic;
    using MechSharingCode.Assets.Scripts.WebService.Models.Inventory;
    using MechSharingCode.WebService.Models.Inventory;

    [MessagePackObject(true)]
    public partial class BattleInfoData
    {
        #region Server usage

        public int BattleId { get; set; }
        public string BlueprintVersion { get; set; }

        #endregion
        
        public BattleMode                             BattleMode      { get; set; }
        public int                                    BattleMapId     { get; set; }
        public int                                    WeatherId       { get; set; }
        public Dictionary<string, BattleUserInfoData> PlayersInfoData { get; set; }
        public Dictionary<int, WeaponInfo>            IdToWeaponInfo  { get; set; } = new();
        public Dictionary<int, PilotInfo>             IdToPilotInfo   { get; set; } = new();
        public long                                   StartTime       { get; set; } = new();
        public long                                   EndTime        { get; set; } = new();
    }

    [MessagePackObject(true)]
    public class BattleUserInfoData
    {
        public UserInfoData                UserInfoData { get; set; }
        public List<int>                   LordIds;
        public List<MechaInfo>             BattleDeck     { get; set; }
    }
}
