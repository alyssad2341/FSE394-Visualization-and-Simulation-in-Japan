using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentTrigger : MonoBehaviour
{

    //public GameObject gameObject;
    

    //attach this file to the trigger box to make the agents stop


    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){  // other is supposed to be an Agent
        // if(other.gameObject.tag == "Agent"){

        //     if(other.gameObject.GetComponent<ChangeColor>().lightCount == 1){
        //         other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = false;;
        //     }else{
        //         other.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().isStopped = true;

        //     }
        //     print("Agent");
        // }
    }


}
