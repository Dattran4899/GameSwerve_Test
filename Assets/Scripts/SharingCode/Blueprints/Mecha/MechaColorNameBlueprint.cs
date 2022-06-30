namespace MechSharingCode.Blueprints.Mecha
{
    using MechSharingCode.Blueprints.BlueprintReader;

    /// <summary>
    ///     Only use for randomize mecha
    /// </summary>
    [CsvHeaderKey("Id")]
    [BlueprintReader("MechaColorName", blueprintScope: BlueprintScope.Server)]
    public class MechaColorBlueprint : GenericBlueprintReaderByRow<int, MechaColorRecord>
    {
    }

    public class MechaColorRecord
    {
        public int    Id        { get; set; }
        public string ColorName { get; set; }
    }
}