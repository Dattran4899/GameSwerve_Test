using System;
using System.Collections.Generic;
using System.Text;

namespace MechSharingCode.WebService.Inventory
{
    public partial class BattleDeck
    {
        public string Name { set; get; }
        public List<int> MechaIds { set; get; } = new List<int>();
    }
}
