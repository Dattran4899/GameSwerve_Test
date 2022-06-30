using System;

namespace MechSharingCode.Blueprints.Currency
{
    using MechSharingCode.Blueprints.BlueprintReader;

    [CsvHeaderKey("Id")]
    [BlueprintReader("CurrencyAll")]
    public class CurrencyBlueprint : GenericBlueprintReaderByRow<string, CurrencyRecord>
    {
      
    }

    public class CurrencyRecord
    {
        public string Id           { set; get; }
        public string Rarity       { set; get; }
        public string Name         { get; set; }
        public string Description  { get; set; }
        public string ImageAsset   { get; set; }
        // Should we use enum here?
        public string Type         { get; set; }
        public string TokenAddress { get; set; }
        public string TokenId      { get; set; }
        public int TokenDecimal    { get; set; }

        public bool IsToken()
        {
            return Type.Equals("Token", StringComparison.InvariantCultureIgnoreCase);
        }

        public bool IsItem()
        {
            return !IsToken();
        }
    }
}
