namespace MechSharingCode.WebService.Models.Inventory
{
    using MechSharingCode.Assets.Scripts.WebService.Models.Inventory;

    public partial class WeaponData
    {
        public int        Amount     { get; set; }
        public WeaponInfo WeaponInfo { get; set; }
    }
}