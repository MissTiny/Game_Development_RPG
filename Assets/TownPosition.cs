using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player_1");
        if(Listener.lastlevel == 1)
        {
            player.transform.position = new Vector3((float)-5.162604,(float) -4.98,(float) 0.4082011);
        }else if(Listener.lastlevel == 9)
        {
            player.transform.position = new Vector3((float)13.11, (float)3.07, (float)0.4082011);
        }else if(Listener.lastlevel == 12)
        {
            player.transform.position = new Vector3((float)-7.02, (float)3.07, (float)0.4082011);
        }
        else
        {
            player.transform.position = new Vector3((float)0.8507242, (float)3.276049, (float)-0.3410841);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
