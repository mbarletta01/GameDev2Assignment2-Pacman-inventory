using UnityEngine;
using UnityEngine.InputSystem;

public class PacManController : MonoBehaviour
{
    
    private float movespeed = 3f;
    
    private Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      float horizontalInput = Input.GetAxis("Horizontal");
      float VerticalInput = Input.GetAxis("Vertical");

      rb.linearVelocity = new Vector3(horizontalInput, 0, VerticalInput) * movespeed;
    }
}
