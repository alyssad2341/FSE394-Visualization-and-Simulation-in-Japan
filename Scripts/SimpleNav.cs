using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class SimpleNav : MonoBehaviour
{

    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] goals1 = GameObject.FindGameObjectsWithTag("Goal");
        
        GameObject[] goals2 = GameObject.FindGameObjectsWithTag("Goal2");
        
        GameObject[] goals3 = GameObject.FindGameObjectsWithTag("Goal3");

        // Concatenate all arrays
        GameObject[] goals = new GameObject[goals1.Length + goals2.Length + goals3.Length];
        goals1.CopyTo(goals, 0);
        goals2.CopyTo(goals, goals1.Length);
        goals3.CopyTo(goals, goals1.Length + goals2.Length);

        int rand = Random.Range(0, goals.Length);

        goal = (goals[rand]).transform; //without drag and drop

        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(goal.position);
        agent.speed = Random.Range(1f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        // float dis = Vector3.Distance(goal.position, transform.position);
        // if(dis<0.1f){
        //     int currNum = PlayerPrefs.GetInt("AgentNum");
        //     currNum++;
        //     PlayerPrefs.SetInt("AgentNum", currNum);
        // }
    }

    public void StopAgent(){
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.isStopped = true;
    }
}
