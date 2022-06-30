namespace MechSharingCode.Blueprints.Setting
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("MainSetting")]
    public class MainSettingBlueprint : GenericBlueprintReaderByRow<string, MainSettingRecord>
    {
    }

    public class MainSettingRecord
    {
        public string Id              { get; set; }
        public string KeyLocalization { get; set; }
        public string Value           { get; set; }
        public string TypeView        { get; set; }
    }
}