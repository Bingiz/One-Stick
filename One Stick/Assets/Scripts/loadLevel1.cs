using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel1 : MonoBehaviour
{
    public StickHealth stickHealth;

    public void StartGame(){
        stickHealth = GameObject.Find("Game Controller").GetComponent<StickHealth>();
        stickHealth.stickHealth = 100f;
        SceneManager.LoadScene("Level_1");
    }

    public void ToMain(){
        Debug.Log("ToMain");
        SceneManager.LoadScene("Main_Menu");
    }

    public void ExitGame(){
        Debug.Log("Exit");
        SceneManager.LoadScene("Main_Menu");
        Application.Quit();
    }
}
