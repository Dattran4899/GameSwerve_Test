namespace MechSharingCode.Blueprints.BlueprintReader.TypeConversionExtend
{
    using System;
    using global::CsvHelper.TypeConversion;
    using Newtonsoft.Json;

    public class JsonConverter<T> : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, Type typeInfo)
        {
            return JsonConvert.DeserializeObject<T>(text);
        }

        public override string ConvertToString(object value, Type typeInfo)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}