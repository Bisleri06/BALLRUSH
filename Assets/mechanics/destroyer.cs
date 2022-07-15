using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public Transform obstacle;
    public Transform powerup;
    public static int r2 =370;
    public static int count = 0;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacles")
        {
            Destroy(other.gameObject);
            Instantiate(obstacle, new Vector3(Random.Range(-5, 7), 1, Random.Range(80, 160)), Quaternion.identity);

            r2 += 20;

            count++;
            Debug.Log(count);
            if (count % 20 == 0)
            {
                Instantiate(powerup, new Vector3(Random.Range(-4, 6), 1, Random.Range(80, 160)), Quaternion.identity);
            }
        }
        else if (other.gameObject.tag == "powerups")
        {
            Destroy(other.gameObject);
        }
    }
}
