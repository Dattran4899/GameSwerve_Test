// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using MechSharingCode.WebService.Interface;

namespace MechSharingCode.src.WebService.Requests
{
    public class CreateLoginNonceRequestData : IHttpRequestData
    {
       
    }
    public class CreateLoginNonceResponseData : IHttpResponseData
    {
        public string NonceToken { get; set; }
    }
}
