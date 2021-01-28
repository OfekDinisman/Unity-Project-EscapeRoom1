using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class TestLvl3 : MonoBehaviour, IPointerClickHandler
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
        Testlvl3Animation();
    }

    //animation
    public string animationName;
    Animator anim;
    private GameObject endLvl3Effect;
    private GameObject Title3;
    private GameObject Title3endLvl;
    public  void Testlvl3Animation()
    {
        Debug.Log("Testlvl3Animation");
        //move animals
        //move DuckWhite
        GameObject pigBox = GameObject.Find("pigBox");
        pigBox.GetComponent<Animation>().Play("MovePig");
    }
   
    void Start()
    {
        endLvl3Effect = GameObject.Find("Endlvl3Effect");
        endLvl3Effect.SetActive(false);
        //show messages
        Title3endLvl = GameObject.Find("Title3endLvl");
        Title3endLvl.SetActive(false);
        Title3 = GameObject.Find("Title3");
    }
 


}

