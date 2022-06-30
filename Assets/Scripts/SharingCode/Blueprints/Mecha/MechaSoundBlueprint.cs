namespace MechSharingCode.Blueprints.Mecha
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("MechaSound", blueprintScope: BlueprintScope.Client)]
    public class MechaSoundBlueprint : GenericBlueprintReaderByRow<string, MechaSoundRecord>
    {
    }

    public class MechaSoundRecord
    {
        public string                                            Id  { get; set; }
        public BlueprintByRow<string, AnimationStateSoundRecord> StateSoundRecords { get; set; }
    }

    [CsvHeaderKey("AnimName")]
    public class AnimationStateSoundRecord
    {
        public string AnimName   { get; set; }
        public string SoundName  { get; set; }
        public float  FrameDelay { get; set; }
    }
}