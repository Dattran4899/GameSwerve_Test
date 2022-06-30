// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.src.WebService.Requests
{
    using MechSharingCode.WebService.Models.Inventory;

    [HttpRequestDefinition("quest/progress/get")]
    public class GetQuestProgressRequestData : IHttpRequestData
    {
    }

    public class GetQuestProgressResponseData : IHttpResponseData
    {
        public List<QuestProgressInfo> Quests { get; set; }

        public List<SpecialQuestInfo> SpecialQuestInfos { get; set; }
    }

    public static class UnlockSpecialQuestApiCode
    {
        public const int NotPilotOwner = 1;
        public const int NotEnoughPoints = 2;
        public const int DuplicatedPilot = 3;
        public const int PilotsEmpty = 4;
        public const int HasPilotDefault = 5;
    }

    [HttpRequestDefinition("quest/special/unlock")]
    public class UnlockSpecialQuestRequestData : IHttpRequestData
    {
        public List<int> PilotIds { set; get; }
        public int Index { set; get; }
    }

    public class UnlockSpecialQuestResponseData : IHttpResponseData
    {
        public SpecialQuestInfo Quest { set; get; }
    }

    public static class RerollSpecialQuestApiCode
    {
        public const int CannotReroll = 1;
    }

    [HttpRequestDefinition("quest/special/reroll")]
    public class RerollSpecialQuestRequestData : IHttpRequestData
    {
        public int Index { set; get; }
    }

    public class RerollSpecialQuestResponseData : UnlockSpecialQuestResponseData
    {
    }

    public class SpecialQuestInfo
    {
        public string Id { get; set; }
        public int Index { get; set; }
        public bool IsUnlocked { get; set; }
        public bool CanReroll { get; set; }
        public QuestProgressInfo QuestInfo { get; set; }
    }

    public class QuestProgressInfo
    {
        public string QuestId { get; set; }

        //TimeIndex - The index of day(or week, month...) of this quest.It's depends on StartInterval and DurationInterval
        public long TimeIndex { get; set; }
        public long RemainTime { get; set; }
        public int Score { get; set; }
        public bool IsCompleted { get; set; }
    }
}
