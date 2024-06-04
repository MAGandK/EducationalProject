using System;
using System.Text.Json;

namespace Lesson22
{
    public class JSONDateStorage<T> : IDataStorage<T>
	{

        public List<T> Load(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<T>();
            }

            var fileText = File.ReadAllText(filepath);

            return JsonSerializer.Deserialize<List<T>>(filepath);
         }

        public void Save(List<T> items, string filepath)
        {
            var jsonString = JsonSerializer.Serialize(items);
            File.WriteAllText(filepath, jsonString);
        }
    }
}

