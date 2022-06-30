namespace MechSharingCode.Blueprints.VFX
{
    using System.Threading.Tasks;
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Asset")]
    [BlueprintReader("VFXBlueprint", true, blueprintScope: BlueprintScope.Client)]
    public class VFXBlueprint : GenericBlueprintReaderByRow<string, VFXBlueprintRecord>
    {
    }

    public class VFXBlueprintRecord
    {
        public string Asset    { get; set; }
        public string Type     { get; set; }
        public float  LifeTime { get; set; }
    }
}