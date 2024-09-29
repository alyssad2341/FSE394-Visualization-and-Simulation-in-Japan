using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChangeColor : MonoBehaviour
{
    //public int lightCount = 0;
    public Material red;
    public Material green;
    //public Transform car;
    int step = 0;
    public AgentDetect detect;

    
    // Start is called before the first frame update
    void Start()
    {
        //detect = GameObject.Find("PedestrianLight").GetComponent<AgentDetect>();
    }

    // Update is called once per frame
    void Update()
    {

            if (detect.lightCount == 0) {
                GetComponent<Renderer>().enabled = true;
                GetComponent<Renderer>().material = green;
                //prefab_Agent.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;
                //detect.lightCount = 1;
            }
            else if (detect.lightCount == 1) {
                GetComponent<Renderer>().enabled = true;
                GetComponent<Renderer>().material = red;
                //prefab_Agent.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                //detect.lightCount = 0;
            }
    }

    void OnTriggerEnter(Collider other){  // other is supposed to be an Agent
        if(other.tag == "CarView"){

            //Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();

            if(detect.lightCount == 1){
                //other.gameObject.isStopped = true;
                // rb.velocity = Vector3.zero;
                // rb.isKinematic = true;
                other.gameObject.GetComponent<CarView>().isStop = true;
            }else{
                //other.gameObject.isStopped = false;
                other.gameObject.GetComponent<CarView>().isStop = false;
            }
            //print("Agent");
        }
    }
    void OnTriggerStay(Collider other){
        if(other.tag == "CarView"){

            //Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if(detect.lightCount == 0){
                //other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;
                other.gameObject.GetComponent<CarView>().isStop = false;
                other.gameObject.transform.parent.GetComponent<CarMove>().speed = Random.Range(2, 5);
                other.gameObject.transform.parent.GetComponent<Renderer>().material = green;
            }
            //print("Agent");
        }
    }

}
