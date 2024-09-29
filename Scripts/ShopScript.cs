using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{

    public int capacity;
    public int customers;
    bool full;
    public Material red;
    public Material green;
    public Transform prefab_Agent;
    int step;
    Vector3 offset;
    public ResultsPrint results;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("AgentNum", 0);
        customers = 0;
        full = false;
        GetComponent<Renderer>().material = green;
        step = 0;

        if(gameObject.tag == "Goal"){
            offset = new Vector3(1f, 0, -1f);
        }else{
            offset = new Vector3(1f, 0, 1f);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(customers >= capacity){
            GetComponent<Renderer>().material = red;
            full = true;
        }else{
            GetComponent<Renderer>().material = green;
            full = false;
        }
        if(customers > 0){
            step++;
            if(step==3000){
                step = 0;
                Instantiate(prefab_Agent, transform.position+offset, Quaternion.identity);
                customers--;
            }
        }

        
    }

    void OnTriggerEnter(Collider other){  
        if(other.gameObject.tag == "Agent"){
            if(!full){
                Destroy(other.gameObject);
                customers++;
                print("Customers: " + customers);
            }else{
                print("Reached capacity");
                results.numUnhappyPedestrians++;
                Destroy(other.gameObject);
                Instantiate(prefab_Agent, transform.position+offset, Quaternion.identity);
                print("Reached capacity");
            }
        }
    }
}
