using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
         
        // Debug.Log("On Platform");
        if(other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Debug.Log("Off Platform");
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
