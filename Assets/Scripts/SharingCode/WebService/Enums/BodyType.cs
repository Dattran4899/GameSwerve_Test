namespace MechSharingCode.WebService.Inventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BodyType
    {
        Head = 1,
        Core,
        Torso,
        Arm,
        Leg,
        Special
    }
}