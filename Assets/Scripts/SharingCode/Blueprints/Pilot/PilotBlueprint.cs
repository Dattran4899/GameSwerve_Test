using MechSharingCode.Blueprints.BlueprintReader;
using MechSharingCode.WebService.Enums;

namespace MechBlueprintsHelper.Blueprints.Pilot
{
    using System.Collections.Generic;
    using System.Numerics;

    [CsvHeaderKey("Id")]
    [BlueprintReader("PilotBlueprint")]
    public class PilotBlueprint : GenericBlueprintReaderByRow<string, PilotBlueprintRecord>
    {
    }

    public class PilotBlueprintRecord
    {
        public int     Id                { get; set; }
        public string  Name              { get; set; }
        public string  Title             { get; set; }
        public Gender  Gender            { get; set; }
        public string  Birthday          { get; set; }
        public string  Nationality       { get; set; }
        public int     Age               { get; set; }
        public int     Height            { get; set; }
        public int     Weight            { get; set; }
        public string  Description       { get; set; }
        public Vector2 WidthHeightOffset { get; set; }
        public Vector2 PositionOffset    { get; set; }

        public Vector3 Home3DScale        { set; get; }
        public Vector3 Home3DPosition     { get; set; }
        public Vector3 MechaTabScale      { get; set; }
        public Vector3 MechaTabPosition   { get; set; }
        public Vector3 PilotTab3DScale    { get; set; }
        public Vector3 PilotTab3DPosition { get; set; }
        
    }
}