using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTalking : MonoBehaviour
{
    public GameObject Dp;
    public void TaskOnClick()
    {
        Dp.SetActive(false);
        newdialog.index = 0;
    }
}
