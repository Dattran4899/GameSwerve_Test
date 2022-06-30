namespace MechSharingCode.Blueprints.Element
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Element")]
    [BlueprintReader("MechaElementBonusDamage")]
    public class MechaElementBlueprint : GenericBlueprintReaderByRow<Element, MechaElementBlueprintRecord>
    {
    }

    public class MechaElementBlueprintRecord
    {
        public Element                  Element              { get; set; }
        public Dictionary<Element, int> ElementToBonusDamage { get; set; }
    }
}