using System;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoretext;
    void Update()
    {
        scoretext.text =(destroyer.count/2).ToString();
    }
}
