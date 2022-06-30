namespace MechSharingCode.Blueprints.Mecha
{
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.Blueprints.Enums;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Id")]
    [BlueprintReader("MechaStatParameter")]
    public class MechaStatParameterBlueprint : GenericBlueprintReaderByRow<string, MechaStatParameterRecord>
    {
    }

    public class MechaStatParameterRecord
    {
        public string     Id     { get; set; }
        public MechaStat   Stat   { get; set; }
        public StatTarget Target { get; set; }
    }
}