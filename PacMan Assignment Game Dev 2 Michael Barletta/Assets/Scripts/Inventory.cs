using System;
using System.Collections.Generic;
using UnityEngine;

namespace PacmanInventory
{
    public class Inventory : MonoBehaviour
    {
        public event Action<Item> ItemAdded;
        public event Action InventoryChanged;

        private readonly List<Item> m_Items = new List<Item>();

       
        private void OnEnable()  { ItemEvents.Collected += AddItem; }
        private void OnDisable() { ItemEvents.Collected -= AddItem; }

        public void AddItem(Item item)
        {
            m_Items.Add(item);
            item.OnCollect();   
            ItemAdded?.Invoke(item);
            InventoryChanged?.Invoke();
        }

        public bool RemoveItem(Item item)
        {
            bool removed = m_Items.Remove(item);
            if (removed)
                InventoryChanged?.Invoke();
            return removed;
        }

        
        public int GetCount()
        {
            return m_Items.Count;
        }

        public int GetCount(string itemName)
        {
            int count = 0;
            foreach (Item item in m_Items)
            {
                if (item.ItemName == itemName)
                    count++;
            }
            return count;
        }
    }
}