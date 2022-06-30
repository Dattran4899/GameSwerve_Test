namespace MechSharingCode.WebService.Inventory
{
    using System.Collections.Generic;
    using System.Linq;
    using MechSharingCode.Assets.Scripts.WebService.Models.UserData;
    using MechSharingCode.Blueprints;
    using MechSharingCode.WebService.Enums;
    using MechSharingCode.WebService.Helper;
    using MechSharingCode.WebService.Models.Inventory;
    using MessagePack;
    using Newtonsoft.Json;

    [MessagePackObject(true)]
    public partial class MechaInfo
    {
        public int                                Id                 { get; set; }
        public string                             Name               { set; get; }
        public MechaRace                          Race               { set; get; }
        public Dictionary<BodyType, BodyPartInfo> TypeToBodyPartInfo { set; get; } = new();
        public Dictionary<MechaItemType, int>     TypeToItemId       { get; set; } = new();
        public List<int>                          WeaponIds          { set; get; } = new();
        public int?                               PilotId            { set; get; }
        public Element                            Element            { set; get; }

        public int             Level      { get; set; }
        public string          SkeletonId { get; set; }
        public int             LightColor { get; set; }
        public int             Color      { get; set; }
        public int             Mesh       { get; set; }
        public int             Material   { get; set; }
        public int             Texture    { get; set; }
        public MechaGeneration Generation { get; set; }
        public List<StatInfo>  FinalStats { get; set; }

        #region Computation, cache, non-persistence properties

        private List<string>               abilityIdsCache;
        private Dictionary<MechaStat, int> statToFinalValueCache;

        [JsonIgnore]
        [IgnoreMember]
        public List<string> AbilityIds =>
            this.abilityIdsCache ??= MechaHelper.GetAbilityIds(TypeToBodyPartInfo);

        [JsonIgnore]
        [IgnoreMember]
        public Dictionary<MechaStat, int> StatToFinalValue =>
            statToFinalValueCache ??= MechaHelper.ToStatsDictionary(FinalStats);

        #endregion

        private Dictionary<MechaStat, int> statToValueAfterAddingEquipmentStats;
        public Dictionary<MechaStat, int> GetMechaStatToValueAfterAddingEquipmentStats(InventoryData inventoryData)
        {
            if (statToValueAfterAddingEquipmentStats != null)
            {
                return statToValueAfterAddingEquipmentStats;
            }

            var weaponInfos = WeaponIds.Select(weaponId => inventoryData.IdToWeaponData[weaponId]);
            statToValueAfterAddingEquipmentStats = MechaHelper.ToStatsDictionary(FinalStats);
            // TODO: Use dictionary to add stats
            statToValueAfterAddingEquipmentStats[MechaStat.Attack] += weaponInfos.Sum(weaponInfo => weaponInfo.WeaponInfo.Attack);

            return statToValueAfterAddingEquipmentStats;
        }

        public bool HasPilot => this.PilotId != null;
        public bool HasDefaultPilot(MiscParamBlueprint miscParamBlueprint) => this.PilotId == miscParamBlueprint.DefaultPilotId ? true : false;
    }
}
