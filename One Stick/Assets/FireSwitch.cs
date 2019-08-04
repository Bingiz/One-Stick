using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSwitch : MonoBehaviour
{

    public bool isBurning;
    public GameObject fireEffect;
    // Start is called before the first frame update
    void Start()
    {
        fireEffect = transform.FindChild("Fire effect");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider hit){
        if (hit.transform.tag == "Water")
        {
            //extinguish Torch
            fireEffect.SetActive(false);
            isBurning = false;
            transform.gameObject.tag = "Untagged";
        }
        else if (hit.transform.tag == "Fire")
        {
            //light Torch
            fireEffect.SetActive(true);
            isBurning = true;
            transform.gameObject.tag = "Fire";
        }
    }
}
