using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject endPositionObject;
    public Vector3 platformVelocity = new Vector3(0,0,3f);
    private Vector3 endPosition = new Vector3();
    private Vector3 startPosition = new Vector3();
    private bool forward = true;

    public bool activated = true;

    private float timer = 0;
    public float pauseTime = 3f;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        //endPosition = startPosition + new Vector3(0,0,endPointOffset);
        endPosition = endPositionObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activated) { 

            if (forward) { 
                if(transform.position.z >= endPositionObject.transform.position.z)
                {
                    //pause
                    timer = timer + Time.deltaTime;
                    if(timer >= pauseTime)
                    {
                        forward = false;
                        timer = 0;
                    }
                } else
                {
                    //move
                    transform.position += platformVelocity  * Time.deltaTime;
                }
            }
            else
            {
                if (transform.position.z <= startPosition.z)
                {
                    //pause
                    timer = timer + Time.deltaTime;
                    if (timer >= pauseTime)
                    {
                        forward = true;
                        timer = 0;
                    }
                }
                else
                {
                    //move
                    transform.position -= platformVelocity * Time.deltaTime;
                }
            }
        }
    }

    public void Activate()
    {
        activated = true;
    }

    public void Deactivate()
    {
        activated = false;
    }

}
