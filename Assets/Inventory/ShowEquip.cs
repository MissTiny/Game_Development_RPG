using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEquip : MonoBehaviour
{
    public GameObject myEquip;
    
    private bool open;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OpenBag();
    }
    void OpenBag()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            open = myEquip.active;
            open = !open;
            myEquip.SetActive(open);
        }
    }
}
