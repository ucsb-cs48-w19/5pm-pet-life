using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleAni : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent <Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            anim.SetTrigger("Active");

        if (Input.GetMouseButton(1))
            anim.SetTrigger("BarkActive");
    }
}
