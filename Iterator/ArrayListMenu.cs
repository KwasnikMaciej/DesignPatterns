using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ArrayListMenu : IMenu
    {
        private List<string> items;

        public ArrayListMenu()
        {
            items = new List<string>();
            Initialize();
        }

        private void Initialize()
        {
            AddItem("Array List Menu item 1");
            AddItem("Array List Menu item 2");
            AddItem("Array List Menu item 3");
            AddItem("Array List Menu item 4");
            AddItem("Array List Menu item 5");
            AddItem("Array List Menu item 6");
        }

        public void AddItem(string name)
        {
            items.Add(name);
        }

        public List<string> GetItems()
        {
            return items;
        }

        public IIterator CreateIterator()
        {
            return new ArrayListMenuIterator(items);
        }
    }
}
