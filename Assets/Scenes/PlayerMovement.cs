using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sidewaysForce = 200f;

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
        // add a forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // VelocityChange makes the player movement feel smoother
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
