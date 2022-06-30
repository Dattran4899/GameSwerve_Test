namespace MechSharingCode.Blueprints.GameTip
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("GameTip")]
    public class GameTipBlueprint : GenericBlueprintReaderByRow<string, GameTipRecord>
    {
    }

    public class GameTipRecord
    {
        public string Id          { get; set; }
        public string Description { get; set; }
    }
}