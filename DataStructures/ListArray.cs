using System;
using System.ComponentModel;

namespace DataStructures
{
    public class ListArray
    {
        protected Item[] arraylist;
        protected int numItems;
        private int capacity;

        public int Count
        {
            get { return numItems; }
        }
            
        public ListArray():this (capacity:100)
        {
        }
    
        public ListArray(int capacity)
        {
            arraylist = new Item[capacity];
            this.capacity = capacity;
            numItems = 0;
        }

        public virtual void Add(Item item)
        {
            if (!Full())
            {
                arraylist[numItems] = item;
                numItems++;
            }
            if (numItems > (arraylist.Length - 10))
            {
                Array.Resize(ref arraylist, arraylist.Length + 100);
            }
        }

        public bool Full()
        {
            return numItems >= capacity; 
        }

        public bool Empty()
        {
            return numItems == 0;
        }

        public virtual bool Remove (Item item)
        {
            // Removes all items that match item. 
            // Returns true if there was any.
            int location = 0;
            bool result = false;
            while (location < numItems)
            {
                if (arraylist[location].ProductName == item.ProductName)
                {
                    arraylist[location] = arraylist[numItems-1];
                    numItems--;
                    location--; // to ensure item moved up is checked
                    result = true;
                }
                location++;
            }
            if (numItems < arraylist.Length - 110)
            {
                Array.Resize(ref arraylist, arraylist.Length - 100);
            }
            return result;
        }

        public virtual void RemoveAt(int index)
        {
            if (numItems >= index)
            {
                arraylist[index] = arraylist[numItems];
                numItems--;
            }
        }

        public Item Retrieve(int index)
        {
            if (index <= numItems)
            {
                return arraylist[index];
            }
            else
            {
                throw new InvalidOperationException("Index out of boundaries");
            }
        }

        public bool Found(Item item,out int position)
        {
            for (int i = 0; i < numItems; i++)
            {
                if (arraylist[i].ProductName == item.ProductName)
                {
                    position = i;
                    return true;
                }
            }
            position = -1;
            return false;
        }
    }
}
