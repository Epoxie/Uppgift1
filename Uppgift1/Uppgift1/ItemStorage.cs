using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class ItemStorage<T> : IEnumerable<T>
    {
        protected List<T> InternalStorage = new List<T>();

        public List<T> GetAllItems()
        {
            return InternalStorage;
        }

        public void Add(T value)
        {
            InternalStorage.Add(value);
        }

        public void RemoveAt(int index)
        {
            InternalStorage.RemoveAt(index);
        }

        public void Clear()
        {
            InternalStorage = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InternalStorage.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
