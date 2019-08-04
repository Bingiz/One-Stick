using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCharacterMovement : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Animator anim;

    public Camera mainCam;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 lookDirection = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = Camera.main.transform.TransformDirection(moveDirection);
            //moveDirection.y = 0f;
            moveDirection *= speed;

            if (moveDirection.x != 0 || moveDirection.z != 0)
            {
                if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
                {

                    anim.SetBool("isRunning", true);
                }
            }
            else
            {
                anim.SetBool("isRunning", false);
            }


                // Character needs no jump
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                }

                transform.rotation = Quaternion.Euler(transform.eulerAngles.x, mainCam.transform.eulerAngles.y, transform.eulerAngles.z);
                //transform.rotation = mainCam.transform.rotation;
            

        }
        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;
        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
