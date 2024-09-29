using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    //attach this file to the object

    public GameObject correctObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        if (other == null || correctObject == null) return;
        if(other == correctObject.GetComponent<Collider>()){
            if(other.gameObject.GetComponent<MoveAB>().stop == 1){
                other.gameObject.GetComponent<MoveAB>().speed += 0.000035f;
            }else{
                other.gameObject.GetComponent<MoveAB>().accel -= 0.000035f;
            }
            print("Enter");
        }
    }
    void OnTriggerExit(Collider other){
        if (other == null || correctObject == null) return;
        if(other == correctObject.GetComponent<Collider>()){
            //other.gameObject.GetComponent<MoveAB>().accel += 0.000035f;
            other.gameObject.GetComponent<MoveAB>().speed = 0.01f;
            other.gameObject.GetComponent<MoveAB>().accel = 0.0f;
            other.gameObject.GetComponent<MoveAB>().stop = 0;
            print("Exit");
        }
    }
}
