using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSignal : MonoBehaviour
{
    // Attach this to the Traffic Singal Box
    public int step;
    public bool signal;
    public Material green_material; // drag and drop in Unity
    public Material red_material; // drag and drop in Unity

    void Start()
    {
        step = 0;
        signal = true;
    }

    // Update is called once per frame
    void Update()
    {
        step++;
        if(step == 1000)
        {
            step = 0;
            signal = !signal;
            if (signal)  GetComponent<Renderer>().material = green_material;
            else  GetComponent<Renderer>().material = red_material;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CarView" && !signal)
            other.gameObject.GetComponent<CarView>().isStop = true;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "CarView" && signal)
        {
            other.gameObject.GetComponent<CarView>().isStop = false;
            other.gameObject.transform.parent.GetComponent<CarMove>().speed = Random.Range(2, 5);
            other.gameObject.transform.parent.GetComponent<Renderer>().material = green_material;
        }
    }
}
