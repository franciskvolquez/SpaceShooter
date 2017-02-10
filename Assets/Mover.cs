using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        //Sets the velocity in the positive z axis. 
        rb.velocity = transform.forward * speed;
    }
}
