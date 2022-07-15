using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class creator : MonoBehaviour
{
    public Transform obstacle;
    public AudioSource MusicSource;
    public AudioClip MusicClip;
    // Start is called before the first frame update
    void Start()
    {

        for(int i=0;i<20;i++)
        { 
            Instantiate(obstacle, new Vector3(Random.Range(-5, 7), 1, Random.Range(70, 170)), Quaternion.identity);
        }
        MusicSource.clip = MusicClip;
        MusicSource.Play();
    }
}
