namespace MechSharingCode.WebService.Leaderboards
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RewardClaimStatus
    {
        CannotClaim,
        NotClaimedYet,
        Claimed
    }
}