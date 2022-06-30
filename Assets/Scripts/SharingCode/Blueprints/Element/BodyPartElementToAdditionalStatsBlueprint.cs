namespace MechSharingCode.Blueprints.Element
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Element")]
    [BlueprintReader("BodyPartElementToBonusStats")]
    public class BodyPartElementToAdditionalStatsBlueprint : GenericBlueprintReaderByRow<Element, BodyPartElementToAdditionalStatsRecord>
    {
    }

    public class BodyPartElementToAdditionalStatsRecord
    {
        public Element                   Element;
        public Dictionary<MechaStat, int> StatToAdditionalValue;
    }
}
