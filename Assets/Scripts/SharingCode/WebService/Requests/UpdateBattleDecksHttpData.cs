namespace MechSharingCode.WebService.Inventory
{
    using System.Collections.Generic;
    using MechSharingCode.Utils;
    using MechSharingCode.WebService.Interface;

    /// <summary>
    //1- Maximum mechas in battle deck
    //2- Duplicate mecha in battle deck
    //3- MechaId is not exist in user
    /// </summary>
    [HttpRequestDefinition("battle-decks/update")]
    public class UpdateBattleDecksRequestData : IHttpRequestData
    {
        public int ChosenDeck { get; set; }
        public List<BattleDeck> BattleDecks { set; get; } = new();
    }

    public class UpdateBattleDecksResponseData : IHttpResponseData
    {
    }

    public class UpdateBattleDecksApiCode
    {
        public const int MaximumMecha = 1;
        public const int DuplicateMecha = 2;
        public const int MechaNotExist = 3;
        public const int EmptyBattleDecks = 4;
        public const int EmptyMechas = 5;
        public const int ChosenBattleDeckNotValid = 6;
    }
}
