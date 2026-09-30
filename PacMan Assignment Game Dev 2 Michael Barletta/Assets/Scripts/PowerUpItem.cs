using UnityEngine;

namespace PacmanInventory
{
    public class PowerUpItem : Item
    {
        public PowerUpItem() : base("Power Up", 0) { }

        public override void OnCollect()
        {
            Debug.Log("Power up added to inventory. Enemies frozen!");
        }
    }
}