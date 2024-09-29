using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform prefabBullet; // Drag the prefab_Sphere to this slot
    public float shootForce = 100; // Type some value near 1000 in the slot
    int step = 0;
    void Start()
    {

    }

    // Update is called once per frame
    //     void Update()
    //     {
    //         if (Input.GetKeyDown(KeyCode.Space)) {

    //             for(int i=0; i < 5; i++){
    //                 Transform temp = Instantiate(prefabBullet, new Vector3(Random.Range(-4.0f, 4.0f), 4, 0) , Quaternion.identity);
    //                 temp.GetComponent< Rigidbody > ().AddForce(transform.forward * shootForce);
    //             }

    //         }
    //         if(Input.GetKeyDown(KeyCode.LeftShift)){
    //             GameObject[] objs = GameObject.FindGameObjectsWithTag(<"Day1">); //collect all objects with Day1 tag
    //             for (int i = 0; i<objs.Length; i++){
    //                 Destroy(objs[i]);
    //             }
    // //
    //         }
    //     }

    void Update(){

        step++;
        if(step%90 == 0){
            for(int i=0; i < 10; i++){
                Transform temp = Instantiate(prefabBullet, new Vector3(Random.Range(-4, 4), 0.5f, Random.Range(-4, 4)) , Quaternion.identity);
                temp.GetComponent< Rigidbody > ().AddForce((new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100))));
            }
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Day1"); //collect all objects with Day1 tag
            for (int i = 0; i<objs.Length; i++){
                Destroy(objs[i]);
            }
        }


    }

    // void Update()
    // {
    //     step++;
    //     if (step % 90 == 0)
    //     {
    //         for (int i = 0; i < 10; i++)
    //         {
    //             Vector3 pos = new Vector3(Random.Range(-4.0, 4.0), 0, 0);
    //             transform.Rotate(0, Random.value() * 10 * Time.deltaTime, 0);
    //             transform.Translate(Random.value() * 5 * Time.deltaTime, 0, 0);
    //             Transform temp = Instantiate(prefabBullet, pos, Quaternion.identity);
    //             temp.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
    //         }
    //     }
    //     if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         GameObject[] objs = GameObject.FindGameObjectsWithTag("Day1");
    //         for (int i = 0; i < balls.Length; i++)
    //         {
    //             Destroy(objs[i]);
    //         }

    //     }
    // }

}
