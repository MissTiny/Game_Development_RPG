using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class Course_Generator : MonoBehaviour
{
    public GameObject course_btn;
    public Canvas Course_Canvas;
    public GameObject Content;


    void Start()
    {
        ScrollMenu();
    }

    // Update is called once per frame
    void Update()
    {
        //ScrollMenu();
    }
    private void ScrollMenu()
    {
        var children = new List<GameObject>();
        foreach (Transform child in Content.transform) children.Add(child.gameObject);
        children.ForEach(child => Destroy(child));
        CourseList courses = new CourseList();
        for(int i = 0; i < courses.Courses.Count; i++)
        {
            if ((Ability.IQ >= courses.Courses[i].MinimumIQ) && (Ability.Charm >= courses.Courses[i].MinimumCharm) && (Ability.EQ >= courses.Courses[i].MinimumEQ) && (Ability.Imagination >= courses.Courses[i].MinimumImagination)
                   && (Ability.Memory >= courses.Courses[i].MinimumMemory))
            {
                GameObject course = Instantiate(course_btn, Content.transform);
                Text text = course.GetComponentInChildren<Text>();
                text.text = courses.Courses[i].CourseName;
            }
        }
    }
}
