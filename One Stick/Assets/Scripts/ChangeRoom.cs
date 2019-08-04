using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    public GameManager gameManager;
    public Animator anim;

    public bool open = false;

    void Start()
    {   
        anim = transform.Find("Bars").GetComponent<Animator>();
        gameManager = GameObject.Find("Game Controller").GetComponent<GameManager>();
    }


    public void OpenDoor(){
        open = true;
        anim.SetBool("isOpen", true);
    }

    public void closeDoor(){
        open = false;
        anim.SetBool("isOpen", false);
    }
}
