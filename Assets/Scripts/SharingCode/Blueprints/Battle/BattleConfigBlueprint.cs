namespace MechSharingCode.Blueprints.Battle
{
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Models.Inventory;

    [CsvHeaderKey("Mode")]
    [BlueprintReader("BattleConfig")]
    public class BattleConfigBlueprint : GenericBlueprintReaderByRow<BattleMode, BattleConfigRecord>
    {
    }
}
