// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.ComponentModel;

namespace MechSharingCode.WebService.Enums
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PilotRarity
    {
        [Description("Normal")]
        N = 1,
        [Description("Rare")]
        R = 2,
        [Description("Super Rare")]
        SR = 3,
        [Description("Super Super Rare")]
        SSR = 4,
        [Description("Ultra Rare")]
        UR = 5,
        [Description("Limited Rare")]
        LR = 6
    }
}
