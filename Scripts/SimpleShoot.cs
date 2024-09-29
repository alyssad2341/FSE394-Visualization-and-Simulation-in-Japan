using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleShoot : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform prefabBullet; // Drag the prefab_Sphere to this slot
    public float shootForce; // Type some value near 1000 in the slot
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Jump")) {
            Transform temp = Instantiate(prefabBullet, transform.position, Quaternion.identity);
            temp.GetComponent< Rigidbody > ().AddForce(transform.forward * shootForce);
        }
    }

}
