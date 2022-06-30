namespace MechSharingCode.WebService.Inventory
{
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    public class UpdateUserProfileApiCode
    {
        public const int AvatarNotExist = 1;
    }
    
    [HttpRequestDefinition("user/profile/update")]
    public class UpdateUserProfileRequestData : IHttpRequestData
    {
        public string Name { set; get; }
        public string AvatarId { set; get; }
    }

    public class UpdateUserProfileResponseData : IHttpResponseData
    {
    }
}
