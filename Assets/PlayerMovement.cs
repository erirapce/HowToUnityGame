using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;  
    }

    // Update is called once per frame 
    // But we marked it as FixedUpdate because
    // we are using physics in it.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 1000 * Time.deltaTime);
    }
}
