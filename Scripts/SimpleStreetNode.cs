using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStreetNode : MonoBehaviour
{
    // Attach this file to a StreetNode

    public Transform[] nextNodes;  // drag and drop in Unity
    public Vector3[] directions;   // auto set

    void Start()
    {
        if (nextNodes == null) {
            return;
        }
        directions = new Vector3[nextNodes.Length];
        for (int i = 0; i < nextNodes.Length; i++)
            directions[i] = Vector3.Normalize(nextNodes[i].position - transform.position);
    }
    void Update(){}
}