using System.Text.Json;

namespace Lesson18.HomeWork
{
	public class ISerialiser<T>
	{
        public void Serialize(List<T> items, string fileName)
        {
            string jsonString = JsonSerializer.Serialize(items);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine("Serialized JSON:");
            Console.WriteLine(jsonString);
        }

        public List<T> Deserialize(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            List<T> items = JsonSerializer.Deserialize<List<T>>(jsonString);
            Console.WriteLine("\nDeserialized:");
            return items;
        }
    }
}
