using UnityEngine;

namespace PacmanInventory
{
    public abstract class Item 
    {
        public string ItemName { get; protected set; }
        public int Value { get; protected set; }

        protected Item(string itemName, int value)
        {
            ItemName = itemName;
            Value = value;
        }

        public abstract void OnCollect();
    }
        
}

