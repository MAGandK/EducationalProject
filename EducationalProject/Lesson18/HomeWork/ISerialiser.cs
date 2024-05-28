using System;
namespace Lesson18.HomeWork
{
	public interface ISerialiser<T>
	{
        void Serialize(List<T> items, string fileName);

        List<T> Deserialize(string fileName);
    }
}
