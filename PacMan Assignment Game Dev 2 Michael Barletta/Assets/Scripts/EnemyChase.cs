using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    
    
    [SerializeField] private Transform target;
    private NavMeshAgent agent;
 
    private bool isFrozen;
    [SerializeField] private float freezeDuration = 5f;
    private float freezeTimer;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)   
        {
            return;
        }
        if (isFrozen)
        {
            freezeTimer -= Time.deltaTime;
            if (freezeTimer <= 0)
            {
                Unfreeze();
            }
        }
        else
        {
            agent.SetDestination(target.position);
        }

    }
    
    public void Freeze()
    {
        isFrozen = true;
        freezeTimer = freezeDuration;
    }

    public void Unfreeze()
    {
        isFrozen = false;
        freezeTimer = 0f;   
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isFrozen)    
        {
            Destroy(gameObject);
            GameManager.AddScore(100);
        }
        if (other.CompareTag("Player") && !isFrozen)
        {
            GameManager.EndGame("You Lose!");
        }
        
            
    }
}
