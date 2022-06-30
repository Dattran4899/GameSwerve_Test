// Copyright (c) Microsoft.All Rights Reserved.Licensed under the MIT license.See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace MechSharingCode.Utils
{
    [AttributeUsage(AttributeTargets.Enum)]
    public class EnumEnumerableExcludeAttribute : Attribute
    {
        private readonly HashSet<string> exclusions;
        
        public EnumEnumerableExcludeAttribute()
        {
            exclusions = new HashSet<string>();
        }

        public EnumEnumerableExcludeAttribute(params string[] exclusions)
        {
            this.exclusions = exclusions.ToHashSet();
        }

        public bool IsExcluded<TEnum>(TEnum enumValue) where TEnum : Enum
        {
            return exclusions.Contains(enumValue.ToString());
        }
    }
}
