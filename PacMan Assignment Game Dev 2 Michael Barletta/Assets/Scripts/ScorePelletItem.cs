using UnityEngine;

namespace PacmanInventory
{
    public class ScorePelletItem : Item
    {
        public ScorePelletItem() : base("Score Pellet", 10) { }

        public override void OnCollect()
        {
            Debug.Log($"Score pellet added to inventory (+{Value})");
        }
    }
}