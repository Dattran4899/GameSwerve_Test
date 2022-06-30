namespace MechSharingCode.Blueprints.Element
{
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Element")]
    [BlueprintReader("AbilityElementBonusDamage")]
    public class AbilityElementBlueprint : GenericBlueprintReaderByRow<Element, MechaElementBlueprintRecord>
    {
    }
}