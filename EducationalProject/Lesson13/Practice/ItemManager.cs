namespace Lesson13
{
    public class ItemManager<T> : IDataStorage<T>
    {
        private List<T> _items = new();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Add(List<T> items)
        {
            _items.AddRange(items);
        }

        public List<T> Remove(T item)
        {
            _items.Remove(item);

            return _items;
        }
    }

 
}