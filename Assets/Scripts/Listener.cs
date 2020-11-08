using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    // Start is called before the first frame update
    public static Listener instance;
    public GameObject submenu;
    private GameObject temp_submenu;
    private bool submenu_stat = false;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && submenu_stat == false)
        {
            temp_submenu = Instantiate(submenu);
            submenu_stat = !submenu_stat;
            submenu.SetActive(submenu_stat);
        }else if(Input.GetKeyDown(KeyCode.Escape) && submenu_stat == true)
        {
            Destroy(temp_submenu);
            submenu_stat = !submenu_stat;
        }
    }
}
