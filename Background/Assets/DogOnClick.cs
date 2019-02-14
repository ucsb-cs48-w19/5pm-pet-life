using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DogOnClick: MonoBehaviour
{
    //most basic user interactions
	//animaitor component
    public Animator anim;
    Vector3 newPosition;
    Vector3 flatraypos;
   public float speed = 1.5f;

    void Start()
    {
        anim = this.GetComponent <Animator>();
        newPosition = transform.position;
        flatraypos = newPosition;
    }

    void Update()
    {
        GameObject dog = GameObject.Find ("Dog_0");
        RaycastHit hit;
        Ray ray;


        //on leftclick walking animation triggers, moves toward mouseclick
        if (Input.GetMouseButton(0))
        {
        	//raycast to move
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //also limit the movement to x and y axis only
            if (Physics.Raycast(ray, out hit))
             {
                Vector3 rayPosition = hit.point;
                float xupdate=rayPosition.x;
                float zupdate = rayPosition.z;
                //hopefully new vector with the ray's x and y coord while keeping the y
                flatraypos = new Vector3(xupdate, newPosition.y, zupdate);
                //change it to walk faster
                //also get rid of dragging and just make ti move
                transform.position=Vector3.MoveTowards(transform.position, flatraypos, speed*Time.deltaTime);
             }

            //play animation
            //maybe loop to play while object is in motion
           if (dog.transform.GetComponent<Rigidbody>().velocity.x>0 || dog.transform.GetComponent<Rigidbody>().velocity.y > 0)
           {
                anim.SetTrigger("Active");
           }
            

        }

        //onrightclick, no movement, dog barks
        if (Input.GetMouseButton(1)){
        	//
            anim.SetTrigger("BarkActive");
        }
    }
}
