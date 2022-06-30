namespace MechSharingCode.SignalR.DTO
{
    using MechSharingCode.WebService.Models.Inventory;
    using MessagePack;

    [MessagePackObject(keyAsPropertyName: true)]
    public class FindBattleRequestData
    {
        public BattleMode BattleMode { get; set; }
    }
}
