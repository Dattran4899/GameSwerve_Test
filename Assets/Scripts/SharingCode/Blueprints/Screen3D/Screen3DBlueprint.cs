namespace MechSharingCode.Blueprints.Screen3D
{
    using System;
    using System.Numerics;
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("Screen3D", false, BlueprintScope.Client)]
    public class Screen3DBlueprint : GenericBlueprintReaderByRow<string, Screen3DBlueprintRecord>
    {
    }

    public class Screen3DBlueprintRecord
    {
        public string  Id           { set; get; }
        public Vector3 CamPosHolder { get; set; }
        public Vector3 CamRotHolder { get; set; }

        public string EnvironmentActive { get; set; }

        public int                                 HighlightAtSlot  { set; get; }
        public string                              Easing           { get; set; }
        public BlueprintByRow<TeamScreenFocusSlot> TeamScreenFocusSlots { get; set; }
    }

    [Serializable]
    [CsvHeaderKey("SlotId")]
    public class TeamScreenFocusSlot
    {
        public string  SlotId              { get; set; }
        public Vector3 SlotLookAtPosition { get; set; }
        public Vector3 SlotLookAtRotation { get; set; }
    }
}