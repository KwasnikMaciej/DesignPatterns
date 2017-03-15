using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class ArrayMenu : IMenu
    {
        private int actualNumberOfItems;
        private int maxNumberOfItems;

        private string[] items;

        public ArrayMenu()
        {
            actualNumberOfItems = 0;
            maxNumberOfItems = 1000;
            items = new string[maxNumberOfItems];
            Initialize();
        }

        private void Initialize()
        {
            AddItem("Array Menu item 1");
            AddItem("Array Menu item 2");
            AddItem("Array Menu item 3");
            AddItem("Array Menu item 4");
            AddItem("Array Menu item 5");
            AddItem("Array Menu item 6");
        }

        public int AddItem(string item)
        {
            if(actualNumberOfItems < maxNumberOfItems)
            {
                items[actualNumberOfItems] = item;
                return actualNumberOfItems++;
            }
            else
            {
                Console.WriteLine("Operation aborted - Not enough space to add new item");
                return -1;
            }
        }

        public String[] GetItems()
        {
            return items;
        }

        public IIterator CreateIterator()
        {
            return new ArrayMenuIterator(this.items);
        }
    }
}
