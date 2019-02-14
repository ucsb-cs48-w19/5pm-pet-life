using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject Dog_0;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - Dog_0.transform.position;
    }
    

}