namespace MechSharingCode.WebService.Inventory
{
    using MechSharingCode.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    [EnumEnumerableExclude(nameof(None), nameof(All))]
    public enum MechaRace
    {
        None         = 0,
        Legion       = 1,
        Ravager      = 2,
        Giant        = 3,
        Alien        = 4,
        Relic        = 5,
        Shapeshifter = 6,
        Aerial       = 7,
        All          = 8
    }
}