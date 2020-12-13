using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class items_in_bag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject item_btn;
    public GameObject Content;
    void Start()
    {
        ScrollMenu();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ScrollMenu()
    {
        var children = new List<GameObject>();
        foreach (Transform child in Content.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
        for (int i = 0; i < Listener.bag.Count; i++)
        {
            Debug.Log(Listener.bag[i].ItemName);
            GameObject item = Instantiate(item_btn, Content.transform);
            Text text = item.GetComponentInChildren<Text>();
            text.text = Listener.bag[i].ItemName;
        }
    }
}
