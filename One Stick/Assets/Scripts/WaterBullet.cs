using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletSpeed = 3f;
    public Vector3 movement = new Vector3(0,0,0);

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed*10);
    }

    // Update is called once per frame


    void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
    }
}
