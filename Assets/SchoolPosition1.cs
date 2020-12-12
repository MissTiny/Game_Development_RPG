using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolPosition1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player_1");
        if (Listener.lastlevel == 10)
        {
            player.transform.position = new Vector3((float)0.11, (float)-5.4, (float)-1.300058);
        }
        else if (Listener.lastlevel == 2)
        {
            player.transform.position = new Vector3((float)-5.97, (float)6.61, (float)0.4082011);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
