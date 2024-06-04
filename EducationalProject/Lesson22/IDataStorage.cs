using System;
namespace Lesson22
{
	public interface IDataStorage<T>
	{
		public void Save(List<T> items, string filepath);

		List<T> Load(string filepath);
	}
}

