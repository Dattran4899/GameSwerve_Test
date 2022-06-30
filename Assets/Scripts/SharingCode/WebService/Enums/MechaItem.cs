// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

namespace MechSharingCode.WebService.Enums
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MechaItemType
    {
        Title = 15,
        Frame = 16,
        Medal = 17
    }
}
