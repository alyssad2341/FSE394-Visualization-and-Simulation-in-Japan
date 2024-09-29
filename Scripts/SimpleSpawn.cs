using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawn : MonoBehaviour
{
    public Transform prefab_Agent;
    public int step;
    int freq;
    public float density;

    // Start is called before the first frame update
    void Start()
    {
        step = 0;
        density = 1f;
        freq = 3000;
        
    }

    // Update is called once per frame
    void Update()
    {
        freq = (int)(1000*density);
        step++;
        if(step == freq){
            step = 0;
            Instantiate(prefab_Agent, transform.position, Quaternion.identity);
            int currNum = PlayerPrefs.GetInt("AgentNum");
            currNum++;
            PlayerPrefs.SetInt("AgentNum", currNum);
            //Instantiate(prefab_Agent, transform.position, Quaternion.identity);
        }
        
    }
}
