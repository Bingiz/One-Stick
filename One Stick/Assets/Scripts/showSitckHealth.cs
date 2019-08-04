using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showSitckHealth : MonoBehaviour
{
    public StickHealth stickHealth;
    public GameObject Mask;

    void Start()
    {
        stickHealth = GameObject.Find("Game Controller").GetComponent<StickHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(stickHealth.stickHealth/100, 1f);
    }
}
