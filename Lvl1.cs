using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lvl1 : MonoBehaviour
{
    public GameObject wood1;
    public GameObject wood2;
    public GameObject wood3;
    public GameObject wood4;
    private GameObject endLvl1Effect;
    private GameObject txtfinish;
    float x1;
    float x2;
    float x3;
    float x4;
    bool IsPass = false;


    // Start is called before the first frame update
    void Start()
    { //hide end effect
        endLvl1Effect = GameObject.Find("Endlvl1Effect");
        endLvl1Effect.SetActive(false);
        //hide end message
        txtfinish = GameObject.Find("Title1finish");
        txtfinish.SetActive(false);

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //get wood blocks locations
        wood1 = GameObject.Find("VelocityTrackedCube1");
        wood2 = GameObject.Find("VelocityTrackedCube2");
        wood3 = GameObject.Find("VelocityTrackedCube3");
        wood4 = GameObject.Find("VelocityTrackedCube4");
        x1 = wood1.gameObject.transform.position.x;
        x2 = wood2.gameObject.transform.position.x;
        x3 = wood3.gameObject.transform.position.x;
        x4 = wood4.gameObject.transform.position.x;


        // check if they in the correct order
        if (IsPass == false && x1 <= x2 && x2 <= x3 && x3 <= x4)
        {
            IsPass = true;
            Debug.Log("lvl1 pass");
            //show effect
            endLvl1Effect.SetActive(true);
            //show new message
            GameObject txtprev = GameObject.Find("Title1");
            txtprev.SetActive(false);
            txtfinish.SetActive(true);
        }

    }
}
    
