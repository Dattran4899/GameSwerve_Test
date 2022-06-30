// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

namespace MechSharingCode.WebService.Enums
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WeaponRarity
    {
        Common    = 1,
        Uncommon  = 2,
        Rare      = 3,
        Epic      = 4,
        Legendary = 5
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WeaponType
    {
        OneHanded = 1,
        TwoHanded = 2
    }
}
