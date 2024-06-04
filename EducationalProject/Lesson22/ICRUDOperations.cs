using System;
namespace Lesson22
{
	public interface ICRUDOperations<T>
	{
		 void Create(T item);

		 List<T> Read();

         void Update(int index, T item);

         void Delete(int index);
	}
}

