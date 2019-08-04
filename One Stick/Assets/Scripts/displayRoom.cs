using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayRoom : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {   gameManager = GameObject.Find("Game Controller").GetComponent<GameManager>();
        GetComponent<Text>().text = "You reached room " + gameManager.roomNr;
    }
}
