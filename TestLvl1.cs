using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TestLvl1 : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
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
        Testlvl1Animation();
    }

    //animation
    public string animationName;
    Animator anim;

    public  void Testlvl1Animation()
    {
        Debug.Log("Testlvl1Animation");
        animationName = "greenWoodBlock";//first wood block
        GameObject VelocityTrackedCube3 = GameObject.Find("VelocityTrackedCube3");
        VelocityTrackedCube3.GetComponent<Animation>().Play(animationName);

        //2 wood block
        GameObject VelocityTrackedCube4 = GameObject.Find("VelocityTrackedCube4");
        VelocityTrackedCube4.GetComponent<Animation>().Play("yellowWoodBlock");

        //3 wood block
        GameObject VelocityTrackedCube1 = GameObject.Find("VelocityTrackedCube1");
        VelocityTrackedCube1.GetComponent<Animation>().Play("redWoodBlock");

        


    }
   
    void Start()
    {

        //animation
        //anim = GetComponent<Animator>();
    }
 


}

