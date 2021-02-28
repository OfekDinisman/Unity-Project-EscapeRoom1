using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TestLvl2ER2 : MonoBehaviour, IPointerClickHandler
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
        Testlvl2ER2Animation();
    }

    //animation
    public string animationName;
    Animator anim;

    public void Testlvl2ER2Animation()
    {
        Debug.Log("Testlvl2ER2Animation");
        animationName = "MoveSword";//Move Sword
        GameObject Sword = GameObject.Find("MoonSword");
        Sword.GetComponent<Animation>().Play(animationName);
    }

    void Start()
    {

    }
}

