using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TestLvl2 : MonoBehaviour, IPointerClickHandler
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
        Testlvl2Animation();
    }

    //animation
    public string animationName;
    Animator anim;
    private GameObject endLvl2Effect;
    private GameObject lamaObj;
    private GameObject txtfinish;
    private GameObject txtTitle;
    public  void Testlvl2Animation()
    {
        Debug.Log("Testlvl2Animation");
        //show finish lvl message
        txtTitle.SetActive(false);
        txtfinish.SetActive(true);
        lamaObj.SetActive(true);//show lama gift
    }
   
    void Start()
    {
        //hide finish message
        txtfinish = GameObject.Find("Title2endLvl");
        txtfinish.SetActive(false);
        txtTitle=GameObject.Find("Title2");
        lamaObj= GameObject.Find("LlamaBubbleGunLvl2");  //hide lama gift
        lamaObj.SetActive(false);
    }
 


}

