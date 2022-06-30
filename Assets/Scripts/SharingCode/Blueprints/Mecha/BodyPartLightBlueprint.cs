// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using MechSharingCode.Blueprints.BlueprintReader;

namespace MechSharingCode.Blueprints.Mecha
{
    [CsvHeaderKey("Name")]
    [BlueprintReader("BodyPartLight", blueprintScope: BlueprintScope.CLI)]
    public class BodyPartLightBlueprint : GenericBlueprintReaderByRow<string, BodyPartLightBlueprintRecord>
    {
    }

    public class BodyPartLightBlueprintRecord
    {
        public string Name { get; set; }
    }
}
