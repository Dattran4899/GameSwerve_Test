using System;

namespace MechSharingCode.Assets.Scripts.WebService.Models.UserData
{
    public class UserInfo
    {
        public string    Id            { get; set; }
        public string    Name          { get; set; }
        public string    Avatar        { get; set; }
        public DateTime? Birthday      { get; set; }
        public string    WalletAddress { get; set; }
    }
}
