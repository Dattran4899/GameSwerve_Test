namespace MechSharingCode.WebService.Inventory
{
    using System;
    using MechSharingCode.Assets.Scripts.WebService.Models.UserData;
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    [HttpRequestDefinition("user/data/get")]
    public class GetUserDataRequestData : IHttpRequestData
    {
    }

    public class GetUserDataResponseData : IHttpResponseData
    {
        public UserData UserData { get; set; } = new UserData();
    }
}
