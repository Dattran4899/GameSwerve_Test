namespace MechSharingCode.Blueprints.Leaderboards
{
    using System;
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("Season")]
    public class SeasonBlueprint : GenericBlueprintReaderByRow<int, SeasonBlueprintRecord>
    {
    }

    public class SeasonBlueprintRecord
    {
        public int      Id        { get; set; }
        public string   Name      { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime   { get; set; }
    }
}