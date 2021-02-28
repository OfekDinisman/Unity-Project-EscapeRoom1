using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3ER2 : MonoBehaviour
{
    GameObject EndLvl3BloodEffect;
    GameObject Monster;
    float MoonSwordX = 0;

    // Start is called before the first frame update
    void Start()
    {
        Monster = GameObject.Find("Monster");//get Monster obj
        
        EndLvl3BloodEffect = GameObject.Find("EndLvl3BloodEffect");//blood when monster dead
        EndLvl3BloodEffect.GetComponent<ParticleSystem>().Stop();//hide effect blood
    }
   

    private void OnTriggerEnter(Collider other)
    {//pig enter his area
        Debug.Log("OnTriggerEnter");
        Debug.Log(other.tag);
        if (other.gameObject.CompareTag("Sword"))
        {
            Debug.Log("Sword in monster");
            Debug.Log("lvl3 pass");
            //write to log file
            string time = System.DateTime.Now.ToString();
            HandleTextFile.WriteString("finish Level3:" + time);
            Quaternion newRotation = Quaternion.AngleAxis(90, Vector3.up);
            Monster.transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, .05f);
            //show effect
            EndLvl3BloodEffect.GetComponent<ParticleSystem>().Play();
        }
    }
}
