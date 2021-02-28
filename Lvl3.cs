using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lvl3 : MonoBehaviour
{
    private GameObject endLvl3Effect;
    private GameObject Title3;
    private GameObject Title3endLvl;
    private GameObject pigBox;
    bool isPassed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //hide end effect
        endLvl3Effect = GameObject.Find("Endlvl3Effect");
        endLvl3Effect.GetComponent<ParticleSystem>().Stop();
        //get pig object
        pigBox = GameObject.Find("Pig");
        //show messages
        Title3endLvl = GameObject.Find("Title3endLvl");
        Title3endLvl.SetActive(false);
        Title3 = GameObject.Find("Title3");
    }
    private void OnTriggerEnter(Collider other)
    {//pig enter his area
        Debug.Log("OnTriggerEnter");
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("PigArea") && isPassed==false)
        {
            isPassed = true;
            Debug.Log("Pig in his area");
            Debug.Log("lvl3 pass");
            //write to log file
            string time = System.DateTime.Now.ToString();
            HandleTextFile.WriteString("finish Level3:" + time);
            //show effect
            endLvl3Effect.GetComponent<ParticleSystem>().Play();
            //show new message
            Title3.SetActive(false);
            Title3endLvl.SetActive(true);
        }
    }
   
   
}
    
