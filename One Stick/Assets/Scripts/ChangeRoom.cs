using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public GameManager gameManager;

    public bool open = false;

    void Start()
    {
        gameManager = GameObject.Find("Game Controller").GetComponent<GameManager>();
    }
}
