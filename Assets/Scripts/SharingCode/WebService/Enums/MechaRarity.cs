namespace MechSharingCode.WebService.Inventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MechaRarity
    {
        Common    = 1,
        Uncommon  = 2,
        Rare      = 3,
        Epic      = 4,
        Legendary = 5,
        Mythic    = 6
    }
}