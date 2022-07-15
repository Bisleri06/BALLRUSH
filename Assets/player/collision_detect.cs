using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detect : MonoBehaviour
{
    public static bool game_ended;
    public Rigidbody rb;
    public float jump_force;
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "obstacles")
        {
            Time.timeScale = 0;
            game_ended = true;
        }
        else if (other.collider.tag == "powerups")
        {
            Destroy(other.gameObject);
            rb.AddForce(0,jump_force,0,ForceMode.VelocityChange);
        }
    }
}
