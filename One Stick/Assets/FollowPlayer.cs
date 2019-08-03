using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Transform cameraDistance;

    // Start is called before the first frame update
    void Start()
    {
        cameraDistance = GameObject.Find("Camera Distance").transform;
        player = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + cameraDistance.position;
    }
}
