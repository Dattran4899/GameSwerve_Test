// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.


using MechSharingCode.WebService.Authentication;
using MechSharingCode.WebService.Interface;

namespace MechSharingCode.src.WebService.Requests
{
    using Sirenix.OdinInspector;

    public class LoginByWalletRequestData : IHttpRequestData
    {
        [Required]
        public string WalletAddress { get; set; }
        [Required]
        public string Signature { get; set; }
        [Required]
        public string NonceToken { get; set; }
    }
    public class LoginByWalletResponseData : LoginResponseData
    {
    }
}
