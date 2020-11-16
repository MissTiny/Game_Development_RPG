using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBag: MonoBehaviour
{
    public GameObject myBag;
    private bool open;
    
    // Start is called before the first frame update
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        OpenBag();
    }
    void OpenBag()
    {
        if (Input.GetKeyDown(KeyCode.I)) {
            open = myBag.active;
            open = !open;
            myBag.SetActive(open);
        }
    }
}
