using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleWASD : MonoBehaviour
{

    //attacj this file to the moving object
    //public Transform targetA; // drag and drop in Unity
    //public Transform targetB;
    //float speed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if ( Input.GetKey("w") )
        {
            pos.x -= 0.06f;
        }
        if (Input.GetKey("s"))
        {
            pos.x += 0.06f;
        }
        if (Input.GetKey("a"))
        {
            pos.z -= 0.06f;
        }
        if (Input.GetKey("d"))
        {
            pos.z += 0.06f;
        }
            transform.position = pos; // override the udpated position


    }
}
