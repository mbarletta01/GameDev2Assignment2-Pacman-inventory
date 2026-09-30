using UnityEngine;
using System;

namespace PacmanInventory
{
    public static class ItemEvents
    {
        public static event Action<Item> Collected;

        public static void RaiseCollected(Item item)
        {
            Collected?.Invoke(item);
        }
    }
}