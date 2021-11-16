using System.Collections.Generic;

namespace Lesson9._1
{
    public class MyCollection <T>
    {
        private List<T> _items;

        public MyCollection()
        {
            _items = new List<T>(); 
        }

        public void AddToItems(T item)
        {
            _items.Add(item);
        }

        public List<T> ReturnItems()
        {
            return _items; 
        }

        public T ReturnItemsByIndex(int index)
        {
           T item = _items[index];
           return item;
        }

        public int GetItemsCount()
        {
            return _items.Count;
        }
    }
}