using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.WebService.Leaderboards
{
    using MechSharingCode.WebService.Inventory;

    [HttpRequestDefinition("seasons/leaderboards/get")]
    public class GetSeasonalLeaderboardsRequestData : IHttpRequestData
    {
    }

    public class GetSeasonalLeaderboardsResponseData : IHttpResponseData
    {
        public SeasonalLeaderboard       CurrentSeason              { get; set; }
        public List<SeasonalLeaderboard> PreviousSeasons            { get; set; }
        public int                       MaxLeaderboardEntriesCount { get; set; }
    }

    public class SeasonalLeaderboard
    {
        public MechaInfo[]          FavoriteMechas     { get; set; }
        public LeaderboardEntry[]   LeaderboardEntries { get; set; }
        public UserLeaderboardEntry MyLeaderboardEntry { get; set; }
        public int                  SeasonId           { get; set; }
    }

    public class LeaderboardEntry
    {
        public string UserId           { get; set; }
        public string UserName         { get; set; }
        public string UserAvatar       { get; set; }
        public int    Rating           { get; set; }
        public long   Rank             { get; set; }
        public string RankName         { get; set; }
        public int    NumberOfBattles  { get; set; }
        public int    NumberOfWins     { get; set; }
        public int    NumberOfStreaks  { get; set; }
    }

    public class UserLeaderboardEntry
    {
        public string                  UserId            { get; set; }
        public int                     Rating            { get; set; }
        public long                    Rank              { get; set; }
        public string                  DivisionName      { get; set; }
        public string                  DivisionId        { get; set; }
        public Dictionary<string, int> RewardIdToAmount  { get; set; } 
        public RewardClaimStatus       RewardClaimStatus { get; set; }
    }
}
