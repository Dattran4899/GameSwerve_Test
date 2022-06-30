namespace MechSharingCode.Assets.Scripts.WebService.Models.Inventory
{
    using MechSharingCode.WebService.Enums;
    using MechSharingCode.WebService.Inventory;
    using MessagePack;

    [MessagePackObject(true)]
    public partial class WeaponInfo
    {
        public int          Id         { get; set; }
        public string       ModelId    { get; set; }
        public WeaponRarity Rarity     { get; set; }
        public int          Grade      { get; set; }
        public Element      Element    { get; set; }
        
        // TODO: Change these properties to stat dictionary
        public int          Attack     { get; set; }
        public int          EnergyCost { get; set; }
        public int          SpeedCost  { get; set; }
    }
}
