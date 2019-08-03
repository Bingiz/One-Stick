using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{       
        //Character Movement API
        CharacterController characterController;

        public float speed = 6.0f;
        public float jumpSpeed = 8.0f;
        public float gravity = 20.0f;
        public Animator anim;
        public Camera mainCam;

        private Vector3 moveDirection = Vector3.zero;
        private Vector3 lookDirection = new Vector3(0,0,1);
        


        //rotation API
        public float rotSpeed = 6.0f;

    void Start()
        {
        //mainCam = GameObject.Find("Main Camera").GetComponet<Camera>();
            anim = GetComponent<Animator>();
            characterController = GetComponent<CharacterController>();
        }

        void Update()
        {
            if (characterController.isGrounded)
            {
                // We are grounded, so recalculate
                // move direction directly from axes

                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                moveDirection = 
                moveDirection *= speed;

                if(moveDirection.x != 0 || moveDirection.z != 0) { 
                    lookDirection = moveDirection;

                }
            if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                anim.SetBool("isRunning", true);
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

            }

            // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
            // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
            // as an acceleration (ms^-2)
            moveDirection.y -= gravity * Time.deltaTime;

            // Move the controller
            characterController.Move(moveDirection * Time.deltaTime);


            
            //Debug.Log(moveDirection);
            //rotate
            transform.rotation =  Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), 0.15F);



    }
        
        }
