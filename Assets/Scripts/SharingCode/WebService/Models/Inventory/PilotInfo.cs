// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

namespace MechSharingCode.WebService.Models.Inventory
{
    using MechSharingCode.WebService.Enums;
    using MessagePack;

    [MessagePackObject(true)]
    public class PilotInfo
    {
        public int         Id           { get; set; }
        public int         GenerationId { get; set; }
        public string      ModelId      { get; set; }
        public string      AccessoryId  { get; set; }
        public string      HairId       { get; set; }
        public string      OutfitId     { get; set; }
        public string      ArmbandId    { get; set; }
        public PilotRarity Rarity       { get; set; }
    }
}