using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OpenFirstDoor : MonoBehaviour, IPointerClickHandler
{
    public GameObject endLvl1Effect;
    #region IPointerClickHandler implementation

    public void OnPointerClick(PointerEventData eventData)
    {
        MyOwnEventTriggered();
    }
    #endregion

    //my event
    [Serializable]
    public class MyOwnEvent : UnityEvent { }

    [SerializeField]
    private MyOwnEvent myOwnEvent = new MyOwnEvent();
    public MyOwnEvent onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }
    public void MyOwnEventTriggered()
    {
        Debug.Log("Open first door1");
        //write to log file
        string time = System.DateTime.Now.ToString();
        HandleTextFile.WriteString("finish Level1:" + time);
        GameObject doorObj = GameObject.Find("Door");
        doorObj.SetActive(false);//open the door

        //show end effect
        GameObject endLvl1Effectb = GameObject.Find("EndLvl1EffectER2");
        endLvl1Effectb.GetComponent<ParticleSystem>().Play();

    }
}
