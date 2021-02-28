using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))//clicked on space
        {
            if (GetComponent<Renderer>().enabled)//if object is showed
            {
                new WaitForSeconds(1);
                GetComponent<Renderer>().enabled = false; //( hide the game object)
                new WaitForSeconds(1);


            }
            else //if obj is hidden
            {
                new WaitForSeconds(1);

                GetComponent<Renderer>().enabled = true; //( show the game object)
                new WaitForSeconds(1);

            }

        }
    }
}
