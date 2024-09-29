using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGoal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){  
        if(other.gameObject.tag == "Agent"){
            Destroy(other.gameObject);
            int currNum = PlayerPrefs.GetInt("AgentNum");
            currNum--;
            PlayerPrefs.SetInt("AgentNum", currNum);
        }
    }
}
