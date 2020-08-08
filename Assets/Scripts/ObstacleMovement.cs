using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float backwardForce = -2000f; /* - yönde gitsin */
   



    // Update is called once per frame
    void FixedUpdate()
    {
        var theTarget = GameObject.FindWithTag("Obstacle").transform;
        fixedUpdate();
     
    }
    void fixedUpdate()
    {
        rb.AddForce(0, 0, backwardForce * Time.deltaTime);

    }
}

