// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.WebService.Requests
{
    [HttpRequestDefinition("/rewards/onchain/get")]
    public class GetOnchainRewardsRequestData : IHttpRequestData
    {
    }

    public class GetOnchainRewardsResponseData : IHttpResponseData
    {
        public AvaiableOnchainItemRewardInfo Item { get; set; }
        public List<AvailableOnchainTokenRewardInfo> Tokens { get; set; }
    }

    public class AvaiableOnchainItemRewardInfo
    {
        public Dictionary<string, int> RewardIdToAmount { get; set; } = new();
    }

    public class AvailableOnchainTokenRewardInfo
    {
        public string PeriodId { get; set; }
        public Dictionary<string, int> RewardIdToAmountBeforeTax { get; set; } = new();
        public Dictionary<string, int> RewardIdToAmountAfterTax { get; set; } = new();
    }
}
