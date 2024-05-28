using System.Text.Json;

namespace Lesson18.HomeWork
{
	public class Serialiser<T> : ISerialiser<T>
	{
        public void Serialize(List<T> items, string fileName)
        {
            if (items == null)
            {
                Console.WriteLine("Empty items");
                return;
            }

            try
            {
                string jsonString = JsonSerializer.Serialize(items);
                File.WriteAllText(fileName, jsonString);
                Console.WriteLine("Serialized JSON:");
                Console.WriteLine(jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error serialization: {ex.Message}");
            }
        }

        public List<T> Deserialize(string fileName)
        {
            try
            {
                string jsonString = File.ReadAllText(fileName);
                List<T> items = JsonSerializer.Deserialize<List<T>>(jsonString);
                Console.WriteLine("\nDeserialized:");
                return items;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {fileName} not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserialization: {ex.Message}");
            }

            return new List<T>();
        }
    }
}
