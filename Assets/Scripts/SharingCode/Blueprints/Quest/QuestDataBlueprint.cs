namespace MechSharingCode.Blueprints.Quest
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("QuestData")]
    public class QuestDataBlueprint : GenericBlueprintReaderByRow<string, QuestDataRecord>
    {
    }

    public class QuestDataRecord
    {
        public string                  Id                   { get; set; }
        public string                  Name                 { get; set; }
        public string                  Description          { get; set; }
        public int                     IntervalStartingTime { get; set; }
        public int                     IntervalDuration     { get; set; }
        public Dictionary<string, int> RewardIdToAmount     { get; set; }
        public string                  BackgroundUrl        { get; set; }
        public List<ViewType>          ViewType             { get; set; }
        public QuestData               Data                 { get; set; }

        public long GetTimeIndex(long currentTimestampInSeconds)
        {
            return (currentTimestampInSeconds - IntervalStartingTime) / IntervalDuration;
        }

        public long GetRemainTime(long timeIndex)
        {
            return (timeIndex + 1) * IntervalDuration + IntervalStartingTime;
        }
    }

    public class QuestData
    {
        public int                          RequireScore       { get; set; }
        public IEnumerable<QuestActionData> Actions            { get; set; }
        public string                       OnCompleteActionId { get; set; }
    }

    public class QuestActionData
    {
        public string                  Id                    { get; set; }
        public int                     Score                 { get; set; }
        public Dictionary<string, int> RequirementIdToAmount { get; set; }
    }

    public enum ViewType
    {
        Daily,
        FinishDaily,
        Weekly,
        Login,
        Special
    }
}
