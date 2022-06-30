// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechSharingCode.SignalR;
using MessagePack;

namespace MechSharingCode.src.SignalR.DTO
{
    public static class FindBattleResponseCode
    {
        public static int MatchMakerConditionNotMeet = 1;
        public static int AlreadyInBattle = 2;
    } 
    
    [MessagePackObject(keyAsPropertyName: true)]
    public class FindBattleResponseData : BaseWebsocketResponse
    {
        public List<string> Errors { get; set; } = new();
    }
}
