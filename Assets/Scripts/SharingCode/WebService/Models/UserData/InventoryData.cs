namespace MechSharingCode.Assets.Scripts.WebService.Models.UserData
{
    using System.Collections.Generic;
    using MechSharingCode.WebService.Inventory;
    using MechSharingCode.WebService.Models.Inventory;

    public class InventoryData
    {
        public Dictionary<int, MechaInfo>  IdToMechaInfo       { get; set; } = new();
        public Dictionary<int, WeaponData> IdToWeaponData      { get; set; } = new();
        public Dictionary<int, PilotInfo>  IdToPilotInfo       { get; set; } = new();
        public Dictionary<int, int>        IdToMechaItemAmount { get; set; } = new();
    }
}
