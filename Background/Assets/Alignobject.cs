using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Alignobject: MonoBehaviour
{

     public Transform target;
     public Transform current;

    GameObject dog;

    void Start ()
    {
    	//transform of petobject initially
		//target=GameObject.FindWithTag("PetObject").transform;
		//current=target;
    }

    void Update()
    {
     //if notice ifferent rotation between the taget and curent state tr to get the both awedljfk
     // Update is called once per frame
     /* looker.LookAt (target); 
         
       float YRotation = looker.eulerAngles.y;
       float XRotation = looker.eulerAngles.x;
         
      Xsmoothlooker.rotation = Quaternion.Slerp(Xsmoothlooker.rotation , Quaternion.Euler(0 , YRotation, 0), Time.deltaTime * Xspeed);
      Ysmoothlooker.rotation = Quaternion.Slerp(Ysmoothlooker.rotation , Quaternion.Euler(XRotation , YRotation, 0), Time.deltaTime * Yspeed);
     */
    }
}
