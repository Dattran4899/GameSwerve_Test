namespace MechSharingCode.Blueprints.Ability
{
    using System;
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    /// <summary>Define a ability data, Name, Description, Icon, Effects....</summary>
    [CsvHeaderKey("Id")]
    [BlueprintReader("Ability")]
    public class AbilityBlueprint : GenericBlueprintReaderByRow<string, AbilityRecord>
    {
        public const string MovementAbilityId = "common_normal_movement";
        public List<TargetType> AffectedTarget(BlueprintByRow<string, AbilityEffect> AbilityEffectPool)
        {
            List<TargetType> listAffectedTarget = new List<TargetType>();
            foreach (var abilityEffect in AbilityEffectPool)
            {
                listAffectedTarget.AddRange(abilityEffect.Value.AffectedTarget);
            }

            return listAffectedTarget;
        }
    }

    public class AbilityRecord
    {
        public string                                Id                { get; set; }
        public string                                Name              { get; set; }
        public string                                Description       { get; set; }
        public EntityType                            OwnerType         { get; set; }
        public AbilityType                           Type              { get; set; }
        public Element                               Element           { get; set; }
        public string                                Icon              { get; set; }
        public int                                   Cooldown          { get; set; }
        public int                                   PenaltyTime       { get; set; }
        public int                                   CastRange         { get; set; }
        public Tuple<AoEType, int, int>              AoE               { get; set; }
        public List<TargetType>                      Target            { get; set; }
        public AbilityEffectType                     EffectCategory    { get; set; }
        public string                                AbilityTimeline   { get; set; }
        public BlueprintByRow<string, AbilityEffect> AbilityEffectPool { get; set; }
    }

    [Serializable]
    [CsvHeaderKey("EffectId")]
    public class AbilityEffect
    {
        public string           EffectId;
        public List<TargetType> AffectedTarget;
        public string           LogicEffect;
        public string           VisualEffect;
    }

    public enum AbilityType
    {
        Active,
        Passive
    }


    public enum EntityType
    {
        Weapon = 1 << 0,
        Mecha  = 1 << 1,
        Pilot  = 1 << 2,
        All    = Weapon | Mecha | Pilot
    }


    public enum AoEType
    {
        Single,
        Straight,
        Round,
        Cone,
    }

    public enum AbilityEffectType
    {
        Damage,
        Movable,
        Heal
    }
}