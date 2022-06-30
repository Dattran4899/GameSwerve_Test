namespace MechSharingCode.Assets.Scripts.WebService.Models.UserData
{
    using System.Collections.Generic;
    using MechSharingCode.WebService.Inventory;

    public class StatisticData
    {
        public int       BattlesCount     { get; set; }
        public int       WinRate          { get; set; }
        public int       WinBattlesCount  { get; set; }
        public int       LongestStreak    { get; set; }
        public List<int> FavoriteMechaIds { get; set; } = new List<int>();
    }
}