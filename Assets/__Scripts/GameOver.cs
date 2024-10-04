using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void clicked()
    {
        SceneManager.LoadScene("_Scene_0"); 
        Debug.Log("Switching to game scene");
    }
    
}