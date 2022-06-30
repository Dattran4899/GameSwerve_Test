// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MechSharingCode.Blueprints.BlueprintReader;

namespace MechSharingCode.src.Blueprints.Quest
{
    [CsvHeaderKey("Id")]
    [BlueprintReader("QuestAction")]
    public class QuestActionBlueprint : GenericBlueprintReaderByRow<string, QuestActionRecord>
    {
    }
    public class QuestActionRecord
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
