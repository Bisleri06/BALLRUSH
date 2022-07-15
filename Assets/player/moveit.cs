using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveit : MonoBehaviour
{
    public Rigidbody rb;
    public float side_force = 0.01f;
    public bool move_right = false;
    public bool move_left = false;


    void Update()
    {
        rb.AddForce(0, 0, 200);
        if (Input.touchCount > 0)
        {
            if(Input.GetTouch(0).position.x > Screen.height/2)
                rb.AddForce(side_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            else
                rb.AddForce(-side_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
