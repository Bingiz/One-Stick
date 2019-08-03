using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text roomNrText;
    public int roomNr =1;

    void Start()
    {
        roomNrText = GameObject.Find("Room Nr").GetComponent<Text>();
        roomNrText.text = "Room " + roomNr.ToString();
    }

    public void CompleteLevel(){

        roomNr += 1;
        Debug.Log("Level Completed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Update()
    {
        roomNrText = GameObject.Find("Room Nr").GetComponent<Text>();
        roomNrText.text = "Room " + roomNr.ToString();
    }
}
