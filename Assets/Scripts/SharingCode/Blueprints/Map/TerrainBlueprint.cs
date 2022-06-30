namespace MechSharingCode.Blueprints.Map
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("TerrainId")]
    [BlueprintReader("Terrain")]
    public class TerrainBlueprint : GenericBlueprintReaderByRow<string, TerrainRecord>
    {
        public const string TerrainDeployTeam = "Deploy_Team_{0}";
    }

    public class TerrainRecord
    {
        public string     TerrainId    { get; set; }
        public string     Name         { get; set; }
        public int        MovementCost { get; set; }
        public string     EffectId     { get; set; }
        public string     AssetPath    { get; set; }
        public List<MechaRace> MovableRaces { get; set; }
    }
}