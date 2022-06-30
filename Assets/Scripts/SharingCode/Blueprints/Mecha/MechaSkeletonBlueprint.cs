namespace MechSharingCode.Blueprints.Mecha
{
    using System.Collections.Generic;
    using System.Numerics;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("SkeletonId")]
    [BlueprintReader("MechaSkeleton")]
    public class MechaSkeletonBlueprint : GenericBlueprintReaderByRow<string, MechaSkeletonRecord>
    {
    }
    
    public class MechaSkeletonRecord
    {
        public string  SkeletonId        { get; set; }
        public MechaRace    Race              { get; set; }
        public string  Name              { get; set; }
        public string  Image             { get; set; }
        public string  Description       { get; set; }
        public string  SkeletonAssetPath { get; set; }
        public Vector2 WidthHeightOffset { get; set; }
        public Vector2 PositionOffset    { get; set; }
    }
}