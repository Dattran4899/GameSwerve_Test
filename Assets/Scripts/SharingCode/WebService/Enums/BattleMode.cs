namespace MechSharingCode.WebService.Models.Inventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BattleMode
    {
        RankingPvP = 1,
        NormalPvP  = 2,
        PvE        = 3,
        Dungeon    = 4
    }
}
