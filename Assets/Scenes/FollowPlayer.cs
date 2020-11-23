using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {   
    // }

    // A datatype that stores the transform (position, scale and rotation) of an object.
    public Transform player; 
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // since FollowPlayer is a script of the main camera object transform refers to the transform of the main camera and .position gives the x,y,z coordinates back. 
        transform.position = player.position + offset;
    }
}
