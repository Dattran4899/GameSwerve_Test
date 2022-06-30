using MechSharingCode.Utils;

namespace MechSharingCode.WebService.Inventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [EnumEnumerableExclude(nameof(None))]
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MechaStat
    {
        None,
        Durability,
        Energy,
        Speed,
        Attack,
        Defense,
        Mobility,
        Evasion,
        CriticalChancePercent,
        CriticalDamagePercent,
        DurabilityPercent,
        AttackPercent,
        EnergyPercent,
        DefensePercent,
        SpeedPercent,
        MobilityPercent,
        EnergyShield,
        HealthPoint,
        HealthPointPercent,
        AirResistance,
        DarkResistance,
        EarthResistance,
        LightResistance,
        FireResistance,
        IceResistance,
        ThunderResistance,
        WaterResistance,
        Accuracy,
        ArmorReduction,
        ArmorReductionPercent,
        PreDefenseDamageReduction,
        PreDefenseDamageReductionPercent,
        PostDefenseDamageReduction,
        PostDefenseDamageReductionPercent,
        MaxHealthPoint
    }
}
