using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolPosition2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player_1");
        if (Listener.lastlevel == 9)
        {
            player.transform.position = new Vector3((float)-4.99, (float)-1.7, (float)0.4082011);
        }
        else if (Listener.lastlevel == 3)
        {
            player.transform.position = new Vector3((float)-4.99, (float)5.06, (float)0.4082011);
        }
        else if (Listener.lastlevel == 8)
        {
            player.transform.position = new Vector3((float)-5.69, (float)2.9, (float)0.4082011);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
