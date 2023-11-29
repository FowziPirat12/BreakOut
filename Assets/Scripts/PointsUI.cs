using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsUI : MonoBehaviour
{
    public Points points;

    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        points = GameObject.FindGameObjectWithTag("Ball").GetComponent<Points>();
    }

    // Update is called once per frame
    void Update()
    {
        int p = points.Point;
        text.text = "Points: " + p;
    }

     
}
