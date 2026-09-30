using UnityEngine;

namespace PacmanInventory
{


    public class ScorePellet : MonoBehaviour
    {

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                ItemEvents.RaiseCollected(new ScorePelletItem());
                Destroy(gameObject);
                GameManager.AddScore(10);
                GameManager.pelletsRemaining--;
                if (GameManager.pelletsRemaining == 0)
                {
                    GameManager.EndGame("You Win!");
                }
            }
        }
    }
}

