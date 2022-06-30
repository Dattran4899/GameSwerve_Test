// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.WebService.Enums;

namespace MechSharingCode.Blueprints.Weapon
{
    using System.Numerics;
    using MechSharingCode.Blueprints.BlueprintReader;
    using MechSharingCode.WebService.Inventory;

    [CsvHeaderKey("Id")]
    [BlueprintReader("Weapon")]
    public class WeaponBlueprint : GenericBlueprintReaderByRow<string, WeaponBlueprintRecord>
    {
    }

    public class WeaponBlueprintRecord
    {
        public string        Id                { get; set; }
        public string        Name              { get; set; }
        public string        Asset             { get; set; }
        public List<Element> AvailableElements { get; set; }
        public WeaponType    Type              { get; set; }
        public MechaRace     Race              { get; set; }
        public string        Description       { get; set; }
        public List<string>  AbilityIds        { get; set; }
        public Vector2       WidthHeightOffset { get; set; }
        public Vector2       PositionOffset    { get; set; }

        public Vector3 MechaWeaponPosition3D { get; set; }
        public Vector3 MechaWeaponRotation3D { get; set; }
        public Vector3 WeaponTabPosition3D   { get; set; }
        public Vector3 WeaponTabRotation3D   { get; set; }
    }
}
