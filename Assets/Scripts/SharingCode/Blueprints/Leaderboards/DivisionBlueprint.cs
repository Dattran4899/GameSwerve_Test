namespace MechSharingCode.Blueprints.Leaderboards
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("DivisionSystem")]
    public class DivisionBlueprint : GenericBlueprintReaderByRow<string, DivisionBlueprintRecord>
    {
    }

    public class DivisionBlueprintRecord
    {
        public string Id        { get; set; }
        public string Name      { get; set; }
        public int    MinRating { get; set; }
        public int    MaxRating { get; set; }
    }
}
