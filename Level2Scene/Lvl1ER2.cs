using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Lvl1ER2 : MonoBehaviour
{
    GameObject endLvl1Effectb;
    // Start is called before the first frame update
    void Start()
    {
        //write to log file
        string time = System.DateTime.Now.ToString();
        HandleTextFile.WriteString("Start escape room 2:" + time);
        //hide end effect
        //GameObject endLvl1Effect = GameObject.FindGameObjectWithTag("EndLvl1EffectER2");
        //endLvl1Effect.GetComponent<Renderer>().enabled = false;
        GameObject endLvl1Effectb = GameObject.Find("EndLvl1EffectER2");
        // endLvl1Effectb.GetComponent<Renderer>().enabled = false;
        endLvl1Effectb.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
}
