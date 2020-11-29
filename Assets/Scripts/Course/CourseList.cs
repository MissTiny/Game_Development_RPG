using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseList
{
    public List<Course> Courses;
    public CourseList(){
        Courses = new List<Course>();
        //Will add some new
        Courses.Add(new Course("Elementary Math I","Math",0,0,0,0,0,null,new Dictionary<string, int>{{"IQ",1}, { "Energy", -10 } }));
        Courses.Add(new Course("Elementary Math II","Math",20,0,0,0,0,new string[] {"Elementary Math I"},new Dictionary<string, int>{{"IQ",2},{"Energy",-10}}));
        Courses.Add(new Course("Elementary Math III","Math",50,0,0,0,0,new string[] {"Elementary Math II"},new Dictionary<string, int>{{"IQ",4}, { "Energy", -10 } }));
        Courses.Add(new Course("Mid-Level Math I","Math",100,0,0,0,0,new string[] {"Elementary Math III"},new Dictionary<string, int>{{"IQ",6}, { "Energy", -10 } }));
        Courses.Add(new Course("Mid-Level Math II","Math",200,0,0,0,0,new string[] {"Mid-Level Math I"},new Dictionary<string, int>{{"IQ",8}, { "Energy", -10 } }));
        Courses.Add(new Course("Mid-Level Math III","Math",300,0,0,0,0,new string[] {"Mid-Level Math II"},new Dictionary<string, int>{{"IQ",10}, { "Energy", -10 } }));
        Courses.Add(new Course("High-Level Math I","Math",500,0,0,0,0,new string[] {"Mid-Level Math III"},new Dictionary<string, int>{{"IQ",12}, { "Energy", -10 } }));
        Courses.Add(new Course("High-Level Math II","Math",650,0,0,0,0,new string[] {"High-Level Math I"},new Dictionary<string, int>{{"IQ",14}, { "Energy", -10 } }));
        Courses.Add(new Course("High-Level Math III","Math",800,0,0,0,0,new string[] {"High-Level Math II"},new Dictionary<string, int>{{"IQ",16}, { "Energy", -10 } }));
        Courses.Add(new Course("Calculus I","Math",1000,0,0,0,0,new string[]{"High-Level Math III"},new Dictionary<string, int>{{"IQ",18}, { "Energy", -10 } }));
    }

    

}
