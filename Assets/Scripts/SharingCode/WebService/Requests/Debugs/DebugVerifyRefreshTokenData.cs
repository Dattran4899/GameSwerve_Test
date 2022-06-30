// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Authentication;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.src.WebService.Requests.Debugs
{
    [HttpRequestDefinition("debug/refreshtoken/verify")]
    public class DebugVerifyRefreshTokenRequestData : IHttpRequestData
    {
        public string RefreshToken { get; set; }
    }

    public class DebugVerifyRefreshTokenResponseData : IHttpResponseData
    {
        public string UserId { get; set; }
        public string RefreshToken { get; set; }
    }
}
