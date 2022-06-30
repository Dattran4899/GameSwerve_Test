namespace MechSharingCode.Blueprints.Quest
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("SpecialQuestRangeData")]
    public class SpecialQuestBlueprint : GenericBlueprintReaderByRow<string, SpecialQuestDataRecord>
    {
    }

    public class SpecialQuestDataRecord
    {
        public string       Id            { get; set; }
        public int          MinPoint      { get; set; }
        public int          MaxPoint      { get; set; }
        public List<string> QuestDataIds  { get; set; }
        public string       Title         { get; set; }
        public string       BackgroundUrl { get; set; }
    }
}