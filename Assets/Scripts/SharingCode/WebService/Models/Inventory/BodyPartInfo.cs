namespace MechSharingCode.WebService.Inventory
{
    using MechSharingCode.WebService.Interface;
    using MessagePack;

    [MessagePackObject(true)]
    public class BodyPartInfo : IBodyPart
    {
        public int         Id        { set; get; }
        public MechaRarity Rarity    { set; get; }
        public BodyType    BodyType  { get; set; }
        public MechaRace   Race      { set; get; }
        public Element     Element   { set; get; }
        public string      AbilityId { get; set; }
    }
}
