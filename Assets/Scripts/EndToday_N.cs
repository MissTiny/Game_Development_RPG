using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndToday_N : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public void TaskOnClick()
    {
        panel.SetActive(false);
    }
}
