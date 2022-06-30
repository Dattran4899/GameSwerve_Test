// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System.Collections.Generic;
using MechSharingCode.Blueprints.BlueprintReader;
using MechSharingCode.WebService.Enums;

namespace MechBlueprintsHelper.Blueprints.Pilot
{

    [CsvHeaderKey("Id")]
    [BlueprintReader("PilotRandomConfig")]
    public class PilotRandomConfigBlueprint : GenericBlueprintReaderByRow<string, PilotRandomConfigRecord>
    {
    }
    public class PilotRandomConfigRecord
    {
        public string Id { get; set; }
        public int GenerationId { get; set; }
        public int StartId { get; set; }
        public Dictionary<PilotRarity, int> RarityToAmount { get; set; }
        public List<string> AvailableModelIds { get; set; }
        public List<string> AvailableHairIds { get; set; }
        public List<string> AvailableAccessoryIds { get; set; }
        public List<string> AvailableArmbandIds { get; set; }
    }

}
