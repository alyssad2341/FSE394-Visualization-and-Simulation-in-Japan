using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleHide : MonoBehaviour
{

    public int myDegree = 300;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Random.Range(0, 360)*Time.deltaTime, 0, Random.Range(0, 360)*Time.deltaTime);
        transform.Translate(Random.Range(0, 10)*Time.deltaTime, 0, Random.Range(0, 10)*Time.deltaTime);
    }
}
