﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadClassroom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TaskOnClick()
    {
        AudioManager.instance.Play("Button Click");
        Application.LoadLevel(3);
    }
}