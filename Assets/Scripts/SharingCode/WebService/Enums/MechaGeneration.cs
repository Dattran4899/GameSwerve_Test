namespace MechSharingCode.WebService.Inventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MechaGeneration
    {
        Origin = 1
    }
}