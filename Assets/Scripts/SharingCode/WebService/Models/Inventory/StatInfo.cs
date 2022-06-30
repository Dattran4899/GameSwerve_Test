// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

namespace MechSharingCode.WebService.Models.Inventory
{
    using MechSharingCode.WebService.Inventory;
    using MessagePack;

    [MessagePackObject(true)]
    public partial class StatInfo
    {
        public MechaStat Stat  { set; get; }
        public int       Value { set; get; }
    }
}