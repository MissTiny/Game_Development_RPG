using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course_Generator : MonoBehaviour
{
    public GameObject course_btn;
    public Canvas Course_Canvas;
    public GameObject Content;


    void Start()
    {
        
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
       

    }
}
