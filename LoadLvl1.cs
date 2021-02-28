using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadLvl1 : MonoBehaviour, IPointerClickHandler
{
    
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
        SceneManager.LoadScene("WorldInteractionDemo");
    }
}
