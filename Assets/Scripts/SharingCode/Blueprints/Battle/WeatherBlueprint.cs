namespace MechSharingCode.Blueprints.Battle
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("Weather")]
    public class WeatherBlueprint : GenericBlueprintReaderByRow<int, WeatherRecord>
    {
        
    }
    
    public class WeatherRecord
    {
        public int    Id          { get; set; }
        public string Name        { get; set; }
        public string Description { get; set; }
        public int EffectId      { get; set; }
    }
}