using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseList
{
    public List<Course> Courses;
    public CourseList(){
        Courses = new List<Course>();


        //Will add some new
        //Math #IQ, EQ, Imagination, Memory, Charm
        Courses.Add(new Course("Elementary Math I","Math",0,0,0,0,0,null,new Dictionary<string, int>{{"IQ",1}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Elementary Math II","Math",20,0,0,0,0,new string[] {"Elementary Math I"},new Dictionary<string, int>{{"IQ",2},{"Energy",-10},{ "Pressure", 10 }}));
        Courses.Add(new Course("Elementary Math III","Math",50,0,0,0,0,new string[] {"Elementary Math II"},new Dictionary<string, int>{{"IQ",4}, { "Energy", -10 },{ "Pressure", 10 }}));
        Courses.Add(new Course("Mid-Level Math I","Math",100,0,0,0,0,new string[] {"Elementary Math III"},new Dictionary<string, int>{{"IQ",6}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Math II","Math",200,0,0,0,0,new string[] {"Mid-Level Math I"},new Dictionary<string, int>{{"IQ",8}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Math III","Math",300,0,0,0,0,new string[] {"Mid-Level Math II"},new Dictionary<string, int>{{"IQ",10}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Math I","Math",500,0,0,0,0,new string[] {"Mid-Level Math III"},new Dictionary<string, int>{{"IQ",12}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Math II","Math",650,0,0,0,0,new string[] {"High-Level Math I"},new Dictionary<string, int>{{"IQ",14}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Math III","Math",800,0,0,0,0,new string[] {"High-Level Math II"},new Dictionary<string, int>{{"IQ",16}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Calculus I","Math",1000,0,0,0,0,new string[]{"High-Level Math III"},new Dictionary<string, int>{{"IQ",18}, { "Energy", -10 },{ "Pressure", 10 } }));

        //Language #IQ, EQ, Imagination, Memory, Charm
        Courses.Add(new Course("Elementary English I","English",0,0,0,0,0,null,new Dictionary<string, int>{{"EQ",1}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Elementary English II","English",0,20,0,0,0,new string[] {"Elementary English I"},new Dictionary<string, int>{{"EQ",2},{"Energy",-10}}));
        Courses.Add(new Course("Elementary English III","English",0,50,0,0,0,new string[] {"Elementary English II"},new Dictionary<string, int>{{"EQ",4}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level English I","English",0,100,0,0,0,new string[] {"Elementary English III"},new Dictionary<string, int>{{"EQ",6}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level English II","English",0,200,0,0,0,new string[] {"Mid-Level English I"},new Dictionary<string, int>{{"EQ",8}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level English III","English",0,300,0,0,0,new string[] {"Mid-Level English II"},new Dictionary<string, int>{{"EQ",10}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level English I","English",0,500,0,0,0,new string[] {"Mid-Level English III"},new Dictionary<string, int>{{"EQ",12}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level English II","English",0,650,0,0,0,new string[] {"High-Level English I"},new Dictionary<string, int>{{"EQ",14}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level English III","English",0,800,0,0,0,new string[] {"High-Level English II"},new Dictionary<string, int>{{"EQ",16}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Rhetoric I","English",0,1000,0,0,0,new string[]{"High-Level English III"},new Dictionary<string, int>{{"EQ",18}, { "Energy", -10 },{ "Pressure", 10 } }));

        //Drawing #IQ, EQ, Imagination, Memory, Charm
        Courses.Add(new Course("Elementary Drawing I","Drawing",0,0,0,0,0,null,new Dictionary<string, int>{{"Imagination",1}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Elementary Drawing II","Drawing",0,0,20,0,0,new string[] {"Elementary Drawing I"},new Dictionary<string, int>{{"Imagination",2},{"Energy",-10}}));
        Courses.Add(new Course("Elementary Drawing III","Drawing",0,0,50,0,0,new string[] {"Elementary Drawing II"},new Dictionary<string, int>{{"Imagination",4}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Drawing I","Drawing",0,0,100,0,0,new string[] {"Elementary Drawing III"},new Dictionary<string, int>{{"Imagination",6}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Drawing II","Drawing",0,0,200,0,0,new string[] {"Mid-Level Drawing I"},new Dictionary<string, int>{{"Imagination",8}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Drawing III","Drawing",0,0,300,0,0,new string[] {"Mid-Level Drawing II"},new Dictionary<string, int>{{"Imagination",10}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Drawing I","Drawing",0,0,500,0,0,new string[] {"Mid-Level Drawing III"},new Dictionary<string, int>{{"Imagination",12}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Drawing II","Drawing",0,0,650,0,0,new string[] {"High-Level Drawing I"},new Dictionary<string, int>{{"Imagination",14}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Drawing III","Drawing",0,0,800,0,0,new string[] {"High-Level Drawing II"},new Dictionary<string, int>{{"Imagination",16}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Sketch I","Drawing",0,0,1000,0,0,new string[]{"High-Level Drawing III"},new Dictionary<string, int>{{"Imagination",18}, { "Energy", -10 },{ "Pressure", 10 } }));


        //Basketball #IQ, EQ, Imagination, Memory, Charm
        Courses.Add(new Course("Elementary Basketball I","Basketball",0,0,0,0,0,null,new Dictionary<string, int>{{"Charm",1}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Elementary Basketball II","Basketball",0,0,0,0,20,new string[] {"Elementary Basketball I"},new Dictionary<string, int>{{"Charm",2},{"Energy",-10}}));
        Courses.Add(new Course("Elementary Basketball III","Basketball",0,0,0,0,50,new string[] {"Elementary Basketball II"},new Dictionary<string, int>{{"Charm",4}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Basketball I","Basketball",0,0,0,0,100,new string[] {"Elementary Basketball III"},new Dictionary<string, int>{{"Charm",6}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Basketball II","Basketball",0,0,0,0,200,new string[] {"Mid-Level Basketball I"},new Dictionary<string, int>{{"Charm",8}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Basketball III","Basketball",0,0,0,0,300,new string[] {"Mid-Level Basketball II"},new Dictionary<string, int>{{"Charm",10}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Basketball I","Basketball",0,0,0,0,500,new string[] {"Mid-Level Basketball III"},new Dictionary<string, int>{{"Charm",12}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Basketball II","Basketball",0,0,0,0,650,new string[] {"High-Level Basketball I"},new Dictionary<string, int>{{"Charm",14}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Basketball III","Basketball",0,0,0,0,800,new string[] {"High-Level Basketball II"},new Dictionary<string, int>{{"Charm",16}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Three-step layup","Basketball",0,0,0,0,1000,new string[]{"High-Level Basketball III"},new Dictionary<string, int>{{"Charm",18}, { "Energy", -10 },{ "Pressure", 10 } }));

        //Spanish #IQ, EQ, Imagination, Memory, Charm
        Courses.Add(new Course("Elementary Spanish I","Spanish",0,0,0,0,0,null,new Dictionary<string, int>{{"Memory",1}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Elementary Spanish II","Spanish",0,0,0,20,0,new string[] {"Elementary Spanish I"},new Dictionary<string, int>{{"Memory",2},{"Energy",-10}}));
        Courses.Add(new Course("Elementary Spanish III","Spanish",0,0,0,50,0,new string[] {"Elementary Spanish II"},new Dictionary<string, int>{{"Memory",4}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Spanish I","Spanish",0,0,0,100,0,new string[] {"Elementary Spanish III"},new Dictionary<string, int>{{"Memory",6}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Spanish II","Spanish",0,0,0,200,0,new string[] {"Mid-Level Spanish I"},new Dictionary<string, int>{{"Memory",8}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Spanish III","Spanish",0,0,0,300,0,new string[] {"Mid-Level Spanish II"},new Dictionary<string, int>{{"Memory",10}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Spanish I","Spanish",0,0,0,500,0,new string[] {"Mid-Level Spanish III"},new Dictionary<string, int>{{"Memory",12}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Spanish II","Spanish",0,0,0,650,0,new string[] {"High-Level Spanish I"},new Dictionary<string, int>{{"Memory",14}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Spanish III","Spanish",0,0,0,800,0,new string[] {"High-Level Spanish II"},new Dictionary<string, int>{{"Memory",16}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Spanish Daily I","Spanish",0,0,0,1000,0,new string[]{"High-Level Spanish III"},new Dictionary<string, int>{{"Memory",18}, { "Energy", -10 },{ "Pressure", 10 } }));


        //Chemistry #IQ, EQ, Imagination, Memory, Charm
        Courses.Add(new Course("Elementary Chemistry I","Chemistry",0,0,0,0,0,null,new Dictionary<string, int>{{"IQ",2}, {"Memory",1},{"EQ",-2},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Elementary Chemistry II","Chemistry",10,0,0,10,0,new string[] {"Elementary Chemistry I"},new Dictionary<string, int>{{"IQ",3},{"Memory",2},{"EQ",-4},{"Energy",-10},{ "Pressure", 10 }}));
        Courses.Add(new Course("Elementary Chemistry III","Chemistry",30,0,0,30,0,new string[] {"Elementary Chemistry II"},new Dictionary<string, int>{{"IQ",5}, {"Memory",4},{"EQ",-5},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Chemistry I","Chemistry",80,0,0,80,0,new string[] {"Elementary Chemistry III"},new Dictionary<string, int>{{"IQ",7}, {"Memory",6},{"EQ",-6},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Chemistry II","Chemistry",150,0,0,150,0,new string[] {"Mid-Level Chemistry I"},new Dictionary<string, int>{{"IQ",9}, {"Memory",8},{"EQ",-7},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Mid-Level Chemistry III","Chemistry",280,0,0,280,0,new string[] {"Mid-Level Chemistry II"},new Dictionary<string, int>{{"IQ",11}, {"Memory",10},{"EQ",-8},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Chemistry I","Chemistry",450,0,0,450,0,new string[] {"Mid-Level Chemistry III"},new Dictionary<string, int>{{"IQ",13}, {"Memory",12},{"EQ",-9},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Chemistry II","Chemistry",600,0,0,600,0,new string[] {"High-Level Chemistry I"},new Dictionary<string, int>{{"IQ",15}, {"Memory",14},{"EQ",-10},{ "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("High-Level Chemistry III","Chemistry",750,0,0,750,0,new string[] {"High-Level Chemistry II"},new Dictionary<string, int>{{"IQ",17},{"Memory",16},{"EQ",-11}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Organic Chemistry I","Chemistry",900,0,0,900,0,new string[]{"High-Level Chemistry III"},new Dictionary<string, int>{{"IQ",19}, {"Memory",18},{"EQ",-12},{ "Energy", -10 },{ "Pressure", 10 } }));


        //Computer Science
        Courses.Add(new Course("Introduction to C++","CS",500,0,0,0,0,new string[] {"Mid-Level Math III"},new Dictionary<string, int>{{"IQ",12}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Web Designer","CS",650,0,0,0,0,new string[] {"Introduction to C++"},new Dictionary<string, int>{{"IQ",14}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("Database","CS",800,0,0,0,0,new string[] {"Web Designer"},new Dictionary<string, int>{{"IQ",16}, { "Energy", -10 },{ "Pressure", 10 } }));
        Courses.Add(new Course("User Interface Design","CS",1000,0,0,0,0,new string[]{"Database"},new Dictionary<string, int>{{"IQ",18}, { "Energy", -10 },{ "Pressure", 10 } }));
    }

    

}
