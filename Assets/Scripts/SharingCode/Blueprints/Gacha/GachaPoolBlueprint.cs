namespace MechSharingCode.Blueprints.Gacha
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("PoolId")]
    [BlueprintReader("GachaPool")]
    public class GachaPoolBlueprint : GenericBlueprintReaderByRow<string, GachaPoolBlueprintRecord>
    {
    }

    public class GachaPoolBlueprintRecord
    {
        public string PoolId      { get; set; }
        public string Name        { get; set; }
        public string Description { get; set; }

        public BlueprintByRow<GachaPoolItemRecord> Items { get; set; }
    }

    public class GachaPoolItemRecord
    {
        public string Item;
        public int    Amount;
        public int    Weight;
    }
}
