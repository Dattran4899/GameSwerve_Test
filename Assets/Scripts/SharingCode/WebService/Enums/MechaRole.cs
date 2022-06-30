using System;
using System.Collections.Generic;
using System.Text;

namespace MechSharingCode.WebService.Inventory
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MechaRole
    {
        Assault = 1,
        Snipers,
        Bombardier,
        Supports
    }
}
