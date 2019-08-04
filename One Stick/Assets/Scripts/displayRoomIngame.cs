using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayRoomIngame : MonoBehaviour
{
    public GameManager gameManager;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Controller").GetComponent<GameManager>();
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Room "+gameManager.roomNr.ToString();
    }
}
