namespace MechSharingCode.Blueprints
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Enums;
    using MechSharingCode.WebService.Inventory;

    [BlueprintReader("MiscParam")]
    public class MiscParamBlueprint : GenericBlueprintReaderByCol
    {
        /// <summary>
        /// Time in seconds
        /// </summary>
        public int ApprovalTimeout { get; set; }

        public int MatchingTimeout      { get; set; }
        public int MatchMakingLimitTime { get; set; }

        /// <summary>
        /// battle time config
        /// </summary>
        public int BattleInitStateTimeoutInSeconds { get; set; }

        public int BattleEcsMessageRetryTimeInMilliseconds         { get; set; }
        public int BattleLoopDelayInMilliseconds                   { get; set; }
        public int BattlePenaltyDurationInSeconds                  { get; set; }
        public int BattleEnsureInBattleLoopDoneDelayInMilliseconds { get; set; }

        public bool           DisableVideoFeature           { get; set; }
        public string         MechaAvatarUri                { get; set; }
        public string         PilotAvatarUri                { get; set; }
        public string         WeaponAvatarUri               { get; set; }
        public List<BodyType> RandomBodyPartAbilityPriority { get; set; }
        public string         UserAvatarUri                 { get; set; }

        public string  ElementUri         { get; set; }
        public string  RaceUri            { get; set; }
        public string  BodyTypeUri        { get; set; }
        public string  LeaderboardTopUri  { get; set; }
        public string  RankingUri         { get; set; }
        public Vector3 DamageTextOffset   { get; set; }
        public float   DamageTextLifetime { get; set; }

        public string BgRarityUri      { get; set; }
        public string SeasonEndPostFix { get; set; }

        public int             AmountOfDeckSlot              { get; set; }
        public string          GettingStartedLink            { get; set; }
        public string          MediumLink                    { get; set; }
        public string          TelegramLink                  { get; set; }
        public string          DiscordLink                   { get; set; }
        public string          YoutubeLink                   { get; set; }
        public string          TwitterLink                   { get; set; }
        public string          MechaNoName                   { get; set; }
        public List<MechaStat> BattleConfirmStat             { get; set; }
        public string          BattleConfirmNoTargetMessage  { get; set; }
        public string          BattleConfirmNoAbilityMessage { get; set; }

        public string QuestUnlockRarity    { get; set; }
        public int    MaxSlotPilotToUnlock { get; set; } = 5;

        public Dictionary<PilotRarity, int> PilotRarityToSpecialQuestPoint   { get; set; }
        public int                          MinPointToUnlockSpecial          { get; set; } = 3;
        public int                          SpecialQuestSlotAmount           { get; set; }
        public long                         SpecialQuestSlotStartInterval    { get; set; }
        public long                         SpecialQuestSlotIntervalDuration { get; set; }
        public Vector2                      WindowScreenResolution           { get; set; } = new Vector2(640, 480);
        public string                       WikiLink                         { get; set; } = "https://mechmaster.fandom.com/wiki/Skills";
        public int                          DefaultPilotId                   { get; set; }

        //TODO change user string format instead

        #region get asset

        public string GetMechaAvatarUrl(int id)                                    => $"{this.MechaAvatarUri}mecha_{id:D4}.png";
        public string GetWeaponAvatarUrl(string id, string rarity, string element) => $"{this.WeaponAvatarUri}{id}_{rarity}_{element}.png";
        public string GetSpriteBodyType(BodyType type)                             => $"{this.BodyTypeUri}{type}";
        public string GetSpriteElement(WebService.Inventory.Element element)       => $"{this.ElementUri}{element}";
        public string GetSpriteRace(MechaRace race)                                => $"{this.RaceUri}{race}";
        public string GetPilotAvatarUrl(int id)                                    => $"{this.PilotAvatarUri}{id % 1000}.png";
        public string GetUserAvatarUrl(string id)                                  => $"{this.UserAvatarUri}{id}.png";
        public string GetBgRaritySprite(MechaRarity rarity)                        => $"{this.BgRarityUri}{rarity}";
        public string GetLeaderboardTopUrl(long id)                                => $"{this.LeaderboardTopUri}{id}";
        public string GetRankingUrl(string rank)                                   => $"{this.RankingUri}{rank}";

        public string GetPilotBgRarity(string rarity) { return $"BG_Pilot_{rarity}"; }

        public string GetWeaponBgRarity(int rarity)             => $"BG_Weapon_{rarity}";
        public long   GetTimeIndex(long currentTimestampInSeconds) { return (currentTimestampInSeconds - SpecialQuestSlotStartInterval) / SpecialQuestSlotIntervalDuration; }

        private float battleLoopDelayInSeconds = -1;


        public float BattleLoopDelayInSeconds
        {
            get
            {
                if (this.battleLoopDelayInSeconds > 0) return this.battleLoopDelayInSeconds;

                this.battleLoopDelayInSeconds = (float)TimeSpan.FromMilliseconds(this.BattleLoopDelayInMilliseconds).TotalSeconds;
                return this.battleLoopDelayInSeconds;
            }
        }

        #endregion
    }
}
