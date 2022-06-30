namespace MechSharingCode.Blueprints.Battle
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [BlueprintReader("BattleFormula")]
    public class BattleFormulaBlueprint : GenericBlueprintReaderByCol
    {
        public string SpeedAtb               { get; set; }
        public string HealthPoint            { get; set; }
        public string EnergyShieldMultiplier { get; set; }
        public string DamageThoughDefense    { get; set; }
    }
}