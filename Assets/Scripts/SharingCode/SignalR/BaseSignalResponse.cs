// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using MessagePack;

namespace MechSharingCode.SignalR
{
    public static class CommonWebsocketResponseCode
    {
        public const int Success = 0;
        public const int UnexpectedError = 1000;
        /// <summary>
        /// Debugging purpose, client should not care about this error
        /// </summary>
        public const int ClientDisconnected = 9999;
    }
    
    [MessagePackObject(true)]
    public class BaseWebsocketResponse
    {
        public int Code { get; set; }
    }
}
