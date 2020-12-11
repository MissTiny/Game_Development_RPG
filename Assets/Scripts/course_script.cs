using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class course_script : MonoBehaviour
{
    public Text text;
    private CourseList courses = new CourseList();
    public void OnClick()
    {
        for(int i = 0; i < courses.Courses.Count; i++)
        {
            if (text.text.Equals(courses.Courses[i].CourseName))
            {
                Listener.AddCoursesIntoList(courses.Courses[i]);
            }
        }
    }
}
