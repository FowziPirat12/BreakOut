using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    // Start is called before the first frame update
    
private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            collision.gameObject.GetComponent<Points>().AddPoints(5);
            collision.gameObject.GetComponent<BallScript>().CheckWin();
            Destroy(gameObject);
            
        }  
    }


}
