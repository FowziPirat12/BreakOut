using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLevels : MonoBehaviour
{
    public void Tillbaka(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);   
    }
}
