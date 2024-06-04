using System;
namespace Lesson22
{
    public class MemoryCRUDOperations<T> : ICRUDOperations<T>
    {

        private List<T> _items = new List<T>();

        public void Create(T item)
        {
            _items.Add(item);
        }

        public void Delete(int index)
        {
            if (index >=0 && index < _items.Count)
            {

                _items.RemoveAt(index);
            }
        }

        public List<T> Read()
        {
            return _items;
        }

        public void Update(int index, T item)
        {
            if (index >= 0 && index < _items.Count)
            {

                _items[index] = item;
            }
        }
    }
}

