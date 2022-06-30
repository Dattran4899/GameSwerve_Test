using MessagePack;

namespace MechSharingCode.SignalR.DTO
{
    public static class BattleCreatedResponseCode
    {
        public static int CannotCreateBattle = 1;
    }
    
    [MessagePackObject(keyAsPropertyName: true)]
    public class BattleCreatedResponseData : BaseWebsocketResponse
    {
        public string BattleToken { get; set; }
    }
}
