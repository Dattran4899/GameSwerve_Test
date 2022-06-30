namespace MechSharingCode.Assets.Scripts.WebService.Models.UserData
{
    public class UserData
    {
        public UserInfo      UserInfo      { get; set; } = new UserInfo();
        public InventoryData InventoryData { get; set; } = new InventoryData();
        public BattleData    BattleData    { get; set; } = new BattleData();
        public StatisticData StatisticData { get; set; } = new StatisticData();
    }
}
