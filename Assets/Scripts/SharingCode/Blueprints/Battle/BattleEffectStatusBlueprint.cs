namespace MechSharingCode.Blueprints.Battle
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("BattleEffectStatus")]
    public class BattleEffectStatusBlueprint : GenericBlueprintReaderByRow<string, BattleEffectStatusRecord>
    {
    }

    public class BattleEffectStatusRecord
    {
        public string           Id          { get; set; }
        public string           Name        { get; set; }
        public string           Description { get; set; }
        public string           Icon        { get; set; }
        public StatusEffectType Type        { get; set; }
    }

    public enum StatusEffectType
    {
        Positive,
        Negative,
        Both
    }
}