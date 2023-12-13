using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update 
    
    
    public float minY = -6.5f;     
    public float maxVelocity = 15f; 
    Rigidbody2D rb; 
    int lives = 3

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(0, 1, 0));
         
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY)
        {
            transform.position = new Vector3(0, -1, 0); 
            //rb.velocity = new Vector3(0,1,0); 
        }

        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }

        private void private void OnCollisionEnter2D(Collision2D colllision) 
        {
            if (collision.gameObject.CompareTag("9-Sliced"));
        }
    
    }
}
