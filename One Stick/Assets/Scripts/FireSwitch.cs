using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSwitch : MonoBehaviour
{

    public bool isBurning;
    public GameObject fireEffect;
    public StickHealth stickHealth;

     public UnityEngine.Events.UnityEvent FireActivate;
    public UnityEngine.Events.UnityEvent FireDeactivate;

   
   

    // Start is called before the first frame update
    void Start()
    {
        stickHealth = GameObject.Find("Game Controller").GetComponent<StickHealth>();
        fireEffect = transform.Find("Fire effect").gameObject;
        if (isBurning){
            Light();
        } else{
            Extinguish();
        }
    }

    void Update(){
       Debug.Log(gameObject.transform.tag);
   }

    void OnTriggerEnter(Collider hit){
        if (hit.transform.tag == "Water")
        {
            Debug.Log("Hit Water");
            if(isBurning){
                //Evoke Deactivate Event
                Deactivate();
                //extinguish Torch
                Extinguish();
            }
        }
        else if (hit.transform.tag == "Player")
        {
            Debug.Log("Hit Player");
            if (stickHealth.burning){
                if(!isBurning){
                    if(stickHealth.burning){
                    //Evoke Activate Event
                    Activate();
                    //light Torch
                    Light();  
                    }
                }
            }
        }
    }

     public void Activate()
    {
        FireActivate.Invoke();
        Debug.Log("Fire is Activated");
    }

    public void Deactivate()
    {
        FireDeactivate.Invoke();
        Debug.Log("Fire is Deactivated");
    }

    void Light(){
        fireEffect.SetActive(true);
            isBurning = true;
            transform.tag = "Fire";
    }

    void Extinguish(){
        fireEffect.SetActive(false);
            isBurning = false;
            transform.tag = "Extinguished";
    }
}
