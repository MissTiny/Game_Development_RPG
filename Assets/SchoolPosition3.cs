using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolPosition3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player_1");
        if (Listener.lastlevel == 2)
        {
            player.transform.position = new Vector3((float)-10.05, (float)1.26, (float)0.4082011);
        }
        else if (Listener.lastlevel == 4)
        {
            player.transform.position = new Vector3((float)-2.05, (float)4.24, (float)0.4082011);
        }
        else if (Listener.lastlevel == 6)
        {
            player.transform.position = new Vector3((float)6.94, (float)4.4, (float)0.4082011);
        }
        else if (Listener.lastlevel == 5)
        {
            player.transform.position = new Vector3((float)15.86, (float)4.24, (float)0.4082011);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
