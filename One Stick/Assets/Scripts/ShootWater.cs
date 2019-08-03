using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWater : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject waterDrop;

    public float timerGoal = 10f;
    public float timer = 0;


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if (timer >= timerGoal)
        {
            timer = 0;
            Instantiate(waterDrop,spawnPos.position,spawnPos.rotation);

        }
    }
}
