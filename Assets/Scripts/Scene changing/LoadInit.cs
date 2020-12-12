using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;


public class LoadInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TaskOnClick()
    {
        Debug.Log(Listener.Current_date);
        if ( Listener.Current_date == 0)
        {

            Application.LoadLevel(13);
        } else{

            Application.LoadLevel(1);
        }

    }
}
