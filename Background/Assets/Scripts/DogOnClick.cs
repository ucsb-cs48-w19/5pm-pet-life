using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DogOnClick: MonoBehaviour
{
    public Animator anim;
    Vector3 newPosition;
    Vector3 flatraypos;
    public float speed = 5f;

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

        if (Input.GetMouseButton(0))
        {
            //raycast to move
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //also limit the movement to x and y axis only
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag != "PetObject")
                {
                    Vector3 rayPosition = hit.point;
                    float xupdate = rayPosition.x;
                    float zupdate = rayPosition.z;
                    flatraypos = new Vector3(xupdate, newPosition.y, zupdate);
                    transform.position = Vector3.MoveTowards(transform.position, flatraypos, 12 * Time.deltaTime);
                }

            }
            anim.SetTrigger("Active");
        }
        else
        {
            anim.SetTrigger("Not Active");
        }
        //raycasting tut
        //myray gives info about the line from where you start and which direction
        //Physics.Raycast(myRay,Raycasthit hitinfo, float distance, int layermask)
        //onrightclick, no movement, dog barks
        if (Input.GetMouseButton(1)){
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //As far as I know, the Out gives you the info about what it hit, like the distance to the hit, the name of the object it hit, the point where it hit, and so on..
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "PetObject")
                    anim.SetTrigger("BarkActive");
            }

        }
    }
}