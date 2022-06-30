namespace MechSharingCode.Blueprints.Event
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("EventHomeBanner", blueprintScope: BlueprintScope.Client)]
    public class EventHomeBannerBlueprint : GenericBlueprintReaderByRow<string, EventHomeBannerRecord>
    {
    }

    public class EventHomeBannerRecord
    {
        public string Id       { get; set; }
        public string ImageURL { get; set; }
        public string FinalURL { get; set; }
    }
}