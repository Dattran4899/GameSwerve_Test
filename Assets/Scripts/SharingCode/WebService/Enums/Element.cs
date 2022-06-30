namespace MechSharingCode.WebService.Inventory
{
    using MechSharingCode.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    [EnumEnumerableExclude(nameof(None))]
    public enum Element
    {
        Fire,
        Ice,
        Thunder,
        Earth,
        Air,
        Water,
        Light,
        Dark,
        None
    }
}