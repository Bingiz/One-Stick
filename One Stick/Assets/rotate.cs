using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    public float rotSpeed = 6f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (Vector3.up *(rotSpeed * Time.deltaTime));
    }
}
