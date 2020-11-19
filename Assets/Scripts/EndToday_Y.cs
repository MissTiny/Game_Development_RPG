using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndToday_Y : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    public void TaskOnClick()
    {
        Listener.addDate();
        panel.SetActive(false);
    }
}
