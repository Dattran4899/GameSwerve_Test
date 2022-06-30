namespace MechSharingCode.Blueprints.Mecha
{
    using System.Collections.Generic;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Id")]
    [BlueprintReader("UserAvatar")]
    public class UserAvatarBlueprint : GenericBlueprintReaderByRow<string, UserAvatarBlueprintRecord>
    {
    }

    public class UserAvatarBlueprintRecord
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
