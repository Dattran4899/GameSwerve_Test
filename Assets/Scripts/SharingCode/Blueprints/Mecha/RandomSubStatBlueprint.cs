namespace MechSharingCode.Blueprints.Mecha
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("RandomId")]
    [BlueprintReader("RandomSubStat", blueprintScope: BlueprintScope.CLI)]
    public class RandomSubStatBlueprint : GenericBlueprintReaderByRow<string, MechaSubStatRecord>
    {
    }

    public class MechaSubStatRecord
    {
        public string RandomId { get; set; }
        public MechaStat Stat { get; set; }
        public MechaRarity Rarity { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public List<Element> ElementRequire { get; set; }
    }
}
