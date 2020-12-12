using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_class : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button;
    public GameObject classui;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        button.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (button.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            classui.SetActive(true);
        }
        
    }
}
