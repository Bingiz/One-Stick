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
            else if(hit.transform.tag == "Fire") {
                //light Torch
                stick.SetActive(true);
                Debug.Log("FEUER");

            }
            else if (hit.transform.tag == "Water")
            {
                //extinguish Torch
            }

        }
    }
}
