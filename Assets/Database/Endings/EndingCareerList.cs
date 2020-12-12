using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCareerList 
{
    public List<EndingCareer> CareerLists{get;set;}
    public EndingCareerList(){
        CareerLists = new List<EndingCareer>();
        CareerLists.Add(new EndingCareer("Mathematician",1,1500,99999,0,99999,0,99999,0,99999,0,99999,30,new string[] {"Calculus I"}));


        CareerLists.Add(new EndingCareer("Software Engineer",1,1200,99999,0,99999,0,99999,0,99999,0,99999,50,new string[] {"User Interface Design"}));


        CareerLists.Add(new EndingCareer("Writer",1,0,99999,1500,99999,0,99999,0,99999,0,99999,30,new string[] {"Rhetoric I"}));


        CareerLists.Add(new EndingCareer("Drawer",1,0,99999,0,99999,1500,99999,0,99999,0,99999,30,new string[] {"Sketch I"}));

        CareerLists.Add(new EndingCareer("Basketball Coach",1,0,99999,0,99999,0,99999,0,99999,1500,99999,100,new string[] {"Three-step layup"}));

        CareerLists.Add(new EndingCareer("Scientist",1,1200,99999,0,99999,0,99999,1200,99999,0,99999,40,new string[] {"Organic Chemistry"}));

        CareerLists.Add(new EndingCareer("Spanish Teacher",1,0,99999,0,99999,0,99999,1200,99999,0,99999,30,new string[] {"Spanish Daily I"}));
        CareerLists.Add(new EndingCareer("Homeless",0,0,99999,0,99999,0,99999,0,99999,0,99999,10,new string[] {}));

    }
}
