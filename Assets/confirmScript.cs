using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;


public class confirmScript : MonoBehaviour
{
    public GameObject canvas;
    public void OnClick()
    {
        canvas.SetActive(false);
    }

}
