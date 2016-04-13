using System;

namespace NPoco
{
    public class FastJSONColumnSerializer : IColumnSerializer
    {
        public fastJSON.JSONParameters JSONParameters { get; set; } = new fastJSON.JSONParameters();

        public string Serialize(object value)
        {
            var serializer = new fastJSON.JSONSerializer(JSONParameters);
            return serializer.ConvertToJSON(value);
        }

        public object Deserialize(string value, Type targetType)
        {
            var deserializer = new fastJSON.deserializer(JSONParameters);
            return deserializer.ToObject(value, targetType);
        }
    }
}