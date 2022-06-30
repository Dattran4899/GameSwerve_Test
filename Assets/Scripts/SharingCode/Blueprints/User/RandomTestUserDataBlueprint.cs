// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.Blueprints.BlueprintReader;
using MechSharingCode.WebService.Enums;

namespace MechSharingCode.Blueprints.User
{
    [BlueprintReader("RandomTestUserData", blueprintScope: BlueprintScope.CLI)]
    public class RandomTestUserDataBlueprint : GenericBlueprintReaderByCol
    {
        public List<PilotRarity> PilotRarityPool { get; set; } = new();
        public List<int> WeaponGradePool { get; set; } = new();
        public List<WeaponRarity> WeaponRarityPool { get; set; } = new();
    }
}
