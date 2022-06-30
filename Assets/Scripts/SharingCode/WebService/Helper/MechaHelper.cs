// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using MechSharingCode.Utils;
using MechSharingCode.WebService.Interface;
using MechSharingCode.WebService.Inventory;
using MechSharingCode.WebService.Models.Inventory;

namespace MechSharingCode.WebService.Helper
{
    public static class MechaHelper
    {
        public static List<string> GetAbilityIds<TBodyPartModel>(Dictionary<BodyType, TBodyPartModel> typeToBodyPart)
            where TBodyPartModel : IBodyPart
        {
            return typeToBodyPart.Values
                .Where(bodyPart => !string.IsNullOrEmpty(bodyPart.AbilityId)).Select(bodyPart => bodyPart.AbilityId)
                .ToList();
        }
        
        public static Dictionary<MechaStat, int> ToStatsDictionary(List<StatInfo> statInfos) 
        {
            var statToValue = new Dictionary<MechaStat, int>();

            if (statInfos != null)
            {
                statToValue = statInfos.ToDictionary(stat => stat.Stat, stat => stat.Value);
            }
            
            Enum.GetValues(typeof(MechaStat)).Cast<MechaStat>().ForEachWithoutExclusions(statName =>
            {
                statToValue.TryAdd(statName, 0);
            });

            return statToValue;
        }
    }
}
