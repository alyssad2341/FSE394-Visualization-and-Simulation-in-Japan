using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public Transform prefab_Car;
    public int step;
    public float density;

    void Start(){ 
        step = 0;
        density = 1;
    }

    // Update is called once per frame
    void Update()
    {
        step++;
        if (step == (int)(2000*density))
        {
            step = 0;
            Instantiate(prefab_Car, transform.position, transform.rotation);
        }

    }
}
