// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;
using MechSharingCode.WebService.Models.BattleData;

namespace MechSharingCode.src.WebService.Requests
{
    [HttpRequestDefinition("battle/history/get")]
    public class GetBattleHistoryRequestData : IHttpRequestData
    {
    }

    public class GetBattleHistoryResponseData : IHttpResponseData
    {
        public List<BattleHistoryData> Battles { get; set; }
    }
}
