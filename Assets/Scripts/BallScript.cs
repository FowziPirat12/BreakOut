using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update 
    
    
    public float minY = -6.5f;     
    public float maxVelocity = 15f; 
    Rigidbody2D rb; 
  
    int lives = 3;

    public GameObject [] livesImage;

    public GameObject gameOverPanel;

    int brickcount = 24; 
    public GameObject youwinPanel;

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
            if (lives <= 0)
            {
                GameOver();
            }
            else 
            {
                transform.position = Vector3.zero; 
                //rb.velocity = Vector3.zero; 
                lives --;
                livesImage[lives].SetActive(false);
            }
        }

        if (rb.velocity.magnitude > maxVelocity)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVelocity);
        }
    
    }

     void GameOver ( ) 
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        Destroy(gameObject);
    }

    public void CheckWin(){
        brickcount--;
        if(brickcount < 1){
            youwinPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
