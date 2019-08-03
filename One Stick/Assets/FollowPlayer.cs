using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    public Transform cameraDistance;

    public bool rotateCamera = true;

    public float rotationSpeed = 5f;

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

        if (rotateCamera)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X")* rotationSpeed, Vector3.up);
        }
    }
}
