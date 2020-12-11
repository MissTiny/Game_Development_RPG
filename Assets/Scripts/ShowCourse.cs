using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

public class ShowCourse : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject courseslist;
    List<Course> Daliy_course_list = Listener.GetCourses();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Daliy_course_list = Listener.GetCourses();
        updateDailyCourse();
    }

    private void updateDailyCourse()
    {
        Text[] texts = courseslist.GetComponentsInChildren<Text>();
        for(int i = 0; i< Daliy_course_list.Count; i++)
        {
            texts[i].text = Daliy_course_list[i].CourseName;
        }
        for(int j = Daliy_course_list.Count; j < 5; j++)
        {
            texts[j].text = "";
        }
        
    }
}
