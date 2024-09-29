using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarView : MonoBehaviour
{
    // Attach this file to the Car View object (not Car)

    // Attach this file to the Car View object (not Car)
    public bool isClose; // used for Front Car
    public bool isStop; // used for Signal
    public Material red_material; // drag and drop
    public Material green_material; // drag and drop
    public ResultsPrint results;

        void Start()
        {
            isClose = false;
            isStop = false;
            gameObject.transform.parent.GetComponent<Renderer>().material =
            green_material;
            GameObject manager = GameObject.FindWithTag("Manager");
            results = manager.GetComponent<ResultsPrint>();
        }
        // Update is called once per frame
        void Update()
        {
            if(isClose || isStop)
            {
                gameObject.transform.parent.GetComponent<CarMove>().speed = 0;
                gameObject.transform.parent.GetComponent<Renderer>().material =
                red_material;
            }
        }
        void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Car"){
                isClose = true;
                results.CarCollisions++;
            } 

        }
        void OnTriggerExit(Collider other)
        {
            if (other.tag == "Car")
            {
            isClose = false;
            gameObject.transform.parent.GetComponent<CarMove>().speed =
            Random.Range(2, 5);
            gameObject.transform.parent.GetComponent<Renderer>().material =
            green_material;
            }
        }

    // public bool isClose; // used for Front Car
    // public bool isStop; // used for Signal
    // public Material red_material;  // drag and drop
    // public Material green_material;  // drag and drop

    // void Start()
    // {
    //     isClose = false;
    //     isStop = false;
    
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     if(isClose) //|| isStop)
    //     {
    //         gameObject.transform.parent.GetComponent<CarMove>().speed = 0;
    //         gameObject.transform.parent.GetComponent<Renderer>().material = red_material;
    //     }else{
    //         gameObject.transform.parent.GetComponent<CarMove>().speed = Random.Range(2,5);
    //         gameObject.transform.parent.GetComponent<Renderer>().material = green_material;
    //     }
    // }
    // void OnTriggerEnter(Collider other)
    // {
    //     if(other.tag == "Car"){
    //         isClose = true;
    //     } 
    // }
    // void OnTriggerExit(Collider other)
    // {
    //     if (other.tag == "Car")
    //     {
    //         isClose = false;
    //         //gameObject.transform.parent.GetComponent<CarMove>().speed = Random.Range(2, 5);
    //         //gameObject.transform.parent.GetComponent<Renderer>().material = green_material;
    //     }
    // }
}
