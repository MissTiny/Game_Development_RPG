using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int nextlevel;
    public int currentlevel;
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            Application.LoadLevel(nextlevel);
        }
        Listener.lastlevel = currentlevel;
    }
}
