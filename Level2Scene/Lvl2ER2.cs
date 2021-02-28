using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2ER2 : MonoBehaviour
{
    GameObject MoonSword;
    GameObject EndLvl2EffectER2Door;
    GameObject EndLvl2EffectER2SwordHit;
    float MoonSwordX = 0;
    bool Lvl2passed = false;
    // Start is called before the first frame update
    void Start()
    {
        MoonSword = GameObject.Find("MoonSword");
        MoonSwordX = MoonSword.gameObject.transform.position.x;
        Lvl2passed = false;
        //hide end effects
        EndLvl2EffectER2Door = GameObject.Find("EndLvl3ER2Explosion");
        EndLvl2EffectER2Door.GetComponent<ParticleSystem>().Stop();
        EndLvl2EffectER2SwordHit = GameObject.Find("EndLvl2EffectER2SwordHit");
        EndLvl2EffectER2SwordHit.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Lvl2passed == false)
        {
            MoonSword = GameObject.Find("MoonSword");
            float currentX = MoonSword.gameObject.transform.position.x;
            if (MoonSwordX != currentX)
            {
                Lvl2passed = true;//pass the lvl
                Debug.Log("pass level 2");
                //write to log file
                string time = System.DateTime.Now.ToString();
                HandleTextFile.WriteString("finish Level2:" + time);
                GameObject door2Obj = GameObject.Find("Door2");//get door obj
                door2Obj.SetActive(false);//open door
                Debug.Log("open door 2");
                //show end effects
                EndLvl2EffectER2Door.GetComponent<ParticleSystem>().Play();
                EndLvl2EffectER2SwordHit.GetComponent<ParticleSystem>().Play();

            }
        }
    }
}
