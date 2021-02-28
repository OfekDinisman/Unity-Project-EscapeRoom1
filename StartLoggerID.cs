using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLoggerID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HandleTextFile.WriteID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
