namespace MechSharingCode.Blueprints.Battle
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("LordPool")]
    public class LordPoolBlueprint : GenericBlueprintReaderByRow<int, LordRecord>
    {
        
    }
    
    public class LordRecord
    {
        public int    Id          { get; set; }
        public string Name        { get; set; }
        public string Description { get; set; }
        public string ImagePath   { get; set; }
        public int EffectId      { get; set; }
    }
}