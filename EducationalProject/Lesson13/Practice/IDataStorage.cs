namespace Lesson13
{
	public interface IDataStorage<T>
    {
		void Add(T item);

		void Add(List<T> items);

		List<T> Remove(T item);
	}
}