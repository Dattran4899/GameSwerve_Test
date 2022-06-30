namespace MechSharingCode.Blueprints.Leaderboards
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Rank")]
    [BlueprintReader("SeasonalRewards")]
    public class SeasonalRewardBlueprint : GenericBlueprintReaderByRow<long, SeasonalRewardBlueprintRecord>
    {
    }

    public class SeasonalRewardBlueprintRecord
    {
        public long                    Rank        { get; set; }
        public string                  RankName    { get; set; }
        public string                  Description { get; set; }
        public Dictionary<string, int> Items       { get; set; }
    }
}
