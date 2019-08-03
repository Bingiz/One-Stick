using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickHealth : MonoBehaviour
{

    public bool burning = false;
    public float burnSpeed = .1f;
    public float stickHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (burning)
        {
            stickHealth -= burnSpeed * Time.deltaTime;
        }
    }
}
