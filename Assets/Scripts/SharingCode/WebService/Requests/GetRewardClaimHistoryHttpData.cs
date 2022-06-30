// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.WebService.Requests
{
    [HttpRequestDefinition("rewards/onchain/item/claim-history/get")]
    public class GetOnchainItemRewardClaimHistoryRequestData : IHttpRequestData
    {
    }

    public class GetOnchainItemRewardClaimHistoryResponseData : PaginatableResponseData<List<OnchainRewardClaimInfo>>, IHttpResponseData
    {
    }
    
    [HttpRequestDefinition("rewards/onchain/token/claim-history/get")]
    public class GetOnchainTokenRewardClaimHistoryRequestData : IHttpRequestData
    {
    }

    public class GetOnchainTokenRewardClaimHistoryResponseData : PaginatableResponseData<List<OnchainRewardClaimInfo>>, IHttpResponseData
    {
    }

    public class OnchainRewardClaimInfo
    {
        public int Id { get; set; }
        public DateTime ClaimTime { get; set; }
        public Dictionary<string, int> RewardIdToAmount { get; set; }
        public OnchainRewardClaimStatus ClaimStatus { get; set; }
    }

    public enum OnchainRewardClaimStatus
    {
        Verifying,
        Claimed
    }
}
