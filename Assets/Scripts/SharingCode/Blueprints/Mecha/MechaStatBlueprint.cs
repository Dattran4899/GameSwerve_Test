namespace MechSharingCode.Blueprints.Mecha
{
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Enums;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Stat")]
    [BlueprintReader("MechaStat")]
    public class MechaStatBlueprint : GenericBlueprintReaderByRow<MechaStat, MechaStatRecord>
    {
    }

    public class MechaStatRecord
    {
        public MechaStat Stat         { get; set; }
        public int       Id           { get; set; }
        public string    Name         { get; set; }
        public MechaStat PercentStat  { get; set; }
        public StatType  StatType     { get; set; }
        public int       Max          { get; set; }
        public int       Min          { get; set; }
        public int       Base         { get; set; }
        public int       SummaryIndex { get; set; }

        public bool IsHasSummary() { return this.SummaryIndex != -1; }
    }
}