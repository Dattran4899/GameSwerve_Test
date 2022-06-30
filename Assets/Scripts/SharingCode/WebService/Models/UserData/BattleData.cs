namespace MechSharingCode.Assets.Scripts.WebService.Models.UserData
{
    using System.Collections.Generic;
    using MechSharingCode.WebService.Inventory;

    public class BattleData
    {
        public int              ChosenDeck  { get; set; }
        public List<BattleDeck> BattleDecks { get; set; } = new List<BattleDeck>();
    }
}
