using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recorder : MonoBehaviour
{
   List<float> Timers;

   List<char> Inputs;

   int i=0;

    void Start()
    {
       Inputs=new List<char>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Inputs.Add('S');

            Debug.Log(Inputs[0]);
        } 
    }

    
}
