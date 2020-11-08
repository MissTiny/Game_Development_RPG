using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class starttalk1_1 : MonoBehaviour
{
    public GameObject Button;
    public GameObject talkUI;
    public Sprite face;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Button.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Button.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            talkUI.SetActive(true);
        }
    }
}
