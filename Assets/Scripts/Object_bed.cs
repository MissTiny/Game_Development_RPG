﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_bed : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Button;
    public GameObject talkUI;
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
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.F))
        {
            talkUI.SetActive(true);
        }
    }
}
