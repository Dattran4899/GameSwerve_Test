// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.WebService.Inventory;

namespace MechSharingCode.WebService.Models.BattleData
{
    public class BattleHistoryData
    {
        public int BattleId { get; set; }
        public string WinnerId { get; set; }
        public BattleInfoData BattleInfoData { get; set; }
        public Dictionary<string, int> RewardIdToAmount { get; set; }
    }
}
