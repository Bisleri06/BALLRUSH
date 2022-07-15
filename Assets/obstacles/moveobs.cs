using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobs : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    void FixedUpdate()
    {       
        rb.AddForce( 0, 0,-Random.Range(force,force+destroyer.r2) * Time.deltaTime, ForceMode.Force);
    }
}
