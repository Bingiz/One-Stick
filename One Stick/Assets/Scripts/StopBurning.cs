using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBurning : MonoBehaviour
{
    public StickHealth stickHealth;

    // Start is called before the first frame update
    void Start()
    {
        stickHealth = GameObject.Find("Game Controller").GetComponent<StickHealth>();
        stickHealth.burning = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
