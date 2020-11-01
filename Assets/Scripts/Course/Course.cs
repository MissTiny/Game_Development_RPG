using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course
{
    // Start is called before the first frame update
    public string CourseName;
    public string Category;
    public int MinimumIQ;
    public int MinimumEQ;
    public int MinimumImagination;
    public int MinimumMemory;
    public int MinimumCharm;
    public string[] PreCourseName;
    public Dictionary<string, int> Gain;

    //teacher can be added in the future
    public Course(string courseName, string category,int iq, int eq, int imagination, int memory, int charm, string[] courses,Dictionary<string,int> gain){
        CourseName = courseName;
        Category = category;
        MinimumCharm = charm;
        MinimumEQ = eq;
        MinimumImagination = imagination;
        MinimumIQ = iq;
        MinimumMemory = memory;
        PreCourseName = courses;
        Gain = gain;
    }


}
