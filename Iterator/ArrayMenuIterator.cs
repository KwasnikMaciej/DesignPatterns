namespace Iterator
{
    public class ArrayMenuIterator : IIterator
    {
        private string[] items;
        private int position;

        public ArrayMenuIterator(string[] items)
        {
            this.items = items;
            position = 0;
        }

        public object GetNext()
        {
            return items[position++];
        }

        public bool HasNext()
        {
            return position < items.Length && items[position + 1] != null;
        }
    }
}