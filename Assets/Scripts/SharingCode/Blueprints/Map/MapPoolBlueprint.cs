namespace MechSharingCode.Blueprints.Map
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("MapId")]
    [BlueprintReader("MapPool",false)]
    public class MapPoolBlueprint : GenericBlueprintReaderByRow<int, MapPoolRecord>
    {
        
    }

    public class MapPoolRecord
    {
        public int      MapId    { get; set; }
        public int      MapWidth { get; set; }
        public int      MapHeight { get; set; }
        public string[] MapData  { get; set; }
        public string VFXMoveAsset { get; set; }
    }
}