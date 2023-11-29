using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public int points = 0;

    public int Point
    {
        get { return points; }
    }
    // Start is called before the first frame update


    static public bool dialogue = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int points)
    {
        this.points += points; 
    }

    
}