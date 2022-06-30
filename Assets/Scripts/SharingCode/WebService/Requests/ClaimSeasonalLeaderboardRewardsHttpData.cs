using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MechSharingCode.WebService.Leaderboards
{
    [HttpRequestDefinition("seasons/leaderboards/rewards/claim")]
    public class ClaimSeasonalLeaderboardRewardsRequestData : IHttpRequestData
    {
    }

    public class ClaimSeasonalLeaderboardRewardsResponseData : IHttpResponseData
    {
        [JsonProperty("items")] public Dictionary<string, long> Items { get; set; }
    }
}
