// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.WebService.Requests
{
    using Sirenix.OdinInspector;

    public class DebugUpdateMechaApiCode
    {
        public const int NotMechaOwner = 1;
        /// <summary>
        /// Token (for general purpose) can be pilot, weapon, frame, medal, title
        /// </summary>
        public const int InvalidToken = 2;
    }
    
    [HttpRequestDefinition("debug/mecha/update")]
    public class DebugUpdateMechaRequestData : IHttpRequestData
    {
        [Required]
        public int MechaId { get; set; }
        public int? PilotId { get; set; }
        [Required]
        public List<int> WeaponIds { get; set; } = new List<int>();
        [Required]
        public List<string> AbilityIds { get; set; } = new List<string>();
    }
    
    public class DebugUpdateMechaResponseData : IHttpResponseData
    {
    }
}
