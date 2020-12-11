using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class itenScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public void OnClick()
    {
        print(text.text);
    }
}
