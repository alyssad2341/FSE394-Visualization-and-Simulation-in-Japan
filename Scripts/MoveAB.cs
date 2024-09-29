using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAB : MonoBehaviour
{
   //attacj this file to the moving object
    // public Transform targetA; // drag and drop in Unity
    // public Transform targetB;

    public Transform[] targets = new Transform[3];
    public float speed = 0.01f;
    public float accel = 0.0f;
    public int stop = 0;

    int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(targets.Length > 0){
            transform.position = targets[0].position;
        }
        speed = 0.01f;
        accel = 0.0f;
        stop = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targets.Length == 0){
            return;
        }
        Transform currentTarget = targets[currentIndex];
        //1. Get the direction
        Vector3 direction = Vector3.Normalize(currentTarget.position - transform.position);
        //2. Rotate the forward using the direction
        transform.rotation = Quaternion.LookRotation(direction);
        //3. UPdate the position
        speed += accel;
        if(speed > 0){
            transform.position += speed*direction;
        }else{
            //speed = 0f;
            accel = 0.000035f;
            stop = 1;
        }

        if(Vector3.Distance(transform.position, currentTarget.position) < 0.1f){
            currentIndex++;
            if(currentIndex >= targets.Length){
                GameObject newTrain = Instantiate(gameObject, targets[0].position, Quaternion.identity);
                newTrain.GetComponent<MoveAB>().targets = targets;
                Destroy(gameObject);
            }
        }

    }
}
