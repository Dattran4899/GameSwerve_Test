using MessagePack;

namespace MechSharingCode.WebService.Inventory
{
    [MessagePackObject(true)]
    public class UserInfoData
    {
        public string Name   { get; set; }
        public string Avatar { get; set; }
    }
}
