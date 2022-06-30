namespace MechSharingCode.Blueprints.Battle
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("BattleDamageType")]
    public class BattleDamageTypeBlueprint : GenericBlueprintReaderByRow<string, BattleDamageTypeRecord>
    {
    }

    public class BattleDamageTypeRecord
    {
        public string Id;
        public string Color;
        public string Text;
    }
}