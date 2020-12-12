using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class Baglist : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject item_text;
    public GameObject Content;
    void Start()
    {
        ScrollMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ScrollMenu()
    {
        var children = new List<GameObject>();
        foreach (Transform child in Content.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
        for (int i = 0; i < Listener.bag.Count; i++)
        {
            GameObject item = Instantiate(item_text, Content.transform);
            Text text = item.GetComponentInChildren<Text>();
            text.text = Listener.bag[i].ItemName + "\n" + Listener.bag[i].ItemDescription;
        }
    }
}
