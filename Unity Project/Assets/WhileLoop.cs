using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;


    void Start ()
    {
        Debug.Log ("I've washed a cup!");
        cupsInTheSink--;
    }
}