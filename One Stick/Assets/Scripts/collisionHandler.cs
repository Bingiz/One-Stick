using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHandler : MonoBehaviour
{
    public GameObject stick;
    public GameManager gameManager;
    public StickHealth stickHealth;

    void Start()
    {
        Debug.Log("stick set to false");
        stick.SetActive(false);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Door")
        {
            Debug.Log("Collision");
            if (hit.gameObject.GetComponent<ChangeRoom>().open) {
                gameManager.CompleteLevel();
            }
        }
        /*
        else if (hit.transform.tag == "Water")
        {
            //extinguish Torch
            stick.SetActive(false);
            Debug.Log("WATER");
            stickHealth.burning = false;
        }
        */

    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.transform.tag == "Water")
        {
            //extinguish Torch
            stick.SetActive(false);
            Debug.Log("WATER");
            stickHealth.burning = false;
        }
        else if (hit.transform.tag == "Fire")
        {
            //light Torch
            stick.SetActive(true);
            Debug.Log("FIRE");
            stickHealth.burning = true;
        }
        else if (hit.transform.tag == "Wind")
        {
            //torch starts burning quicker
            Debug.Log("WIND");
            stickHealth.burnSpeed = stickHealth.windBurnSpeed;
        }
        else if (hit.transform.tag == "Button")
        {
            //torch starts burning quicker
            Debug.Log("BUTTON");
            hit.GetComponent<ActivateButton>().Activate();
        }
    }

    void OnTriggerExit(Collider hit)
    {
        if (hit.transform.tag == "Wind")
        {
            //torch starts burning quicker
            Debug.Log("NO WIND");
            stickHealth.burnSpeed = stickHealth.defaultBurnSpeed;
        }
        else if (hit.transform.tag == "Button")
        {
            //torch starts burning quicker
            Debug.Log("NO BUTTON");
            hit.GetComponent<ActivateButton>().Deactivate();
        }
    }
}
