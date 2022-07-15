using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform pl;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = pl.position;
        transform.position += offset;
    }
}
