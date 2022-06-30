// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using MechSharingCode.Blueprints.BlueprintReader;

namespace MechSharingCode.Blueprints.Reward
{
    [CsvHeaderKey("PeriodId")]
    [BlueprintReader("TokenRewardTax")]
    public class TokenRewardTaxBlueprint : GenericBlueprintReaderByRow<string, TokenRewardTaxRecord>
    {
    }

    public class TokenRewardTaxRecord
    {
        public string PeriodId { get; set; }
        public Dictionary<string, int> RewardIdToTaxPercentage { get; set; }
        public int DayOffsetFrom { get; set; }
        public int DayOffsetTo { get; set; }

        public bool IsInPeriod(DateTime tokenAccumulationDate, DateTime targetDate)
        {
            var offset = Math.Abs(tokenAccumulationDate.Date.Subtract(targetDate).Days);
            return DayOffsetFrom <= offset && offset < DayOffsetTo;
        }

        public Dictionary<string, int> CalculateAmountAfterTax(Dictionary<string, int> rewardIdToAmount)
        {
            return rewardIdToAmount.ToDictionary(pair => pair.Key, pair =>
            {
                if (RewardIdToTaxPercentage.TryGetValue(pair.Key, out var taxPercentage))
                {
                    return pair.Value - pair.Value * taxPercentage / 100;
                }

                return pair.Value;
            });
        }
    }
}
