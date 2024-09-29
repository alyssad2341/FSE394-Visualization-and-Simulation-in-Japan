using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentDetect : MonoBehaviour
{
    public int lightCount = 0;
    public Transform prefab_Agent;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){  // other is supposed to be an Agent
        if(other.gameObject.tag == "Agent"){

            lightCount = 1;
            //print(lightCount);
        }
    }

    void OnTriggerStay(Collider other){
        if(other.gameObject.tag == "Agent"){

            lightCount = 1;
            //print(lightCount);
        }else{
            lightCount = 0;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Agent"){

            lightCount = 0;
            //print(lightCount);
        }
    }
}
