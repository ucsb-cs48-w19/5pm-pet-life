using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    //Variables
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotationRate = 180;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 rotation;

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        
        // is the controller on the ground?
        if (controller.isGrounded)
        {
           
            //Feed moveDirection with input.
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("walk", true);
            }
            else
            {
                anim.SetBool("walk", false);
            }

            if (Input.GetKey(KeyCode.S))
            {
                anim.SetBool("walk_backwards", true);
            }
            else
            {
                anim.SetBool("walk_backwards", false);
            }


            if (Input.GetButton("Fire1"))
            {
                anim.SetTrigger("Wave");
              
            }

            anim.ResetTrigger("Wave");

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
            //Jumping
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

            this.rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationRate * Time.deltaTime, 0);
            this.transform.Rotate(this.rotation);
        }

        //Applying gravity to the controller
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
    }
}