using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuListener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject submenu;
    private bool submenu_state = false;
    void Start()
    {
        submenu.SetActive(submenu_state);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && submenu_state == false)
        {
            submenu_state = !submenu_state;
            submenu.SetActive(submenu_state);
        }else if(Input.GetKeyDown(KeyCode.Escape) && submenu_state == true)
        {
            submenu_state = !submenu_state;
            submenu.SetActive(submenu_state);
        }
    }
}
