using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    public class ArrayListMenuIterator : IIterator
    {
        private List<string> items;
        private int position;

        public ArrayListMenuIterator(List<string> items)
        {
            this.items = items;
            position = 0;
        }

        public object GetNext()
        {
            return items.ElementAt(position++);
        }

        public bool HasNext()
        {
            return position < items.Count - 1;
        }
    }
}