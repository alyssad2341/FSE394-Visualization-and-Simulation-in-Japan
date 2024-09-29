using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    // Attach this file to Car Object

    public float speed = 0;
    float maxSpeed = 6;

    void Start()
    {
        speed = Random.Range(4, maxSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "StreetNode")
        {
            if (other.gameObject.GetComponent<SimpleStreetNode>().nextNodes.Length == 0)
                Destroy(gameObject); // destroy this game object
            else
            {
                int num = other.gameObject.GetComponent<SimpleStreetNode>().nextNodes.Length;
                int rand = Random.Range(0, num);
                Vector3 dir = other.gameObject.GetComponent<SimpleStreetNode>().directions[rand];
                transform.position = other.gameObject.transform.position; // *** ADD this to fit the position
                transform.forward = dir;  // rotate the direction         // change the direction of body
            }
        }
    }
}
