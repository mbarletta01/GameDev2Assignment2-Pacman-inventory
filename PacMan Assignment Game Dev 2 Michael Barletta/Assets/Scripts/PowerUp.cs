
using UnityEngine;

using PacmanInventory;

public class PowerUp : MonoBehaviour
{
    private GameObject[] allEnemies;
    void Start()
    {
        allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
//freeze enemies, activate power up
//if no enemies, return

            foreach (GameObject enemy in allEnemies)    
            {   
                if (enemy == null)
                    continue;
                else{
                    enemy.GetComponent<EnemyChase>().Freeze();
                }
            }
            Destroy(gameObject);
            ItemEvents.RaiseCollected(new PowerUpItem());
        }
    }
}