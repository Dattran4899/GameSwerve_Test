// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechSharingCode.Blueprints.BlueprintReader;

namespace MechSharingCode.src.Blueprints.Gacha
{
    [CsvHeaderKey("id")]
    [BlueprintReader("GachaData")]
    public class GachaDataBlueprint : GenericBlueprintReaderByRow<string, GachaDataRecord>
    {
    }
    public class GachaDataRecord
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Pools { get; set; }
    }
}
