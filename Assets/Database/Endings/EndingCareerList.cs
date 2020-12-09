using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCareerList 
{
    public List<EndingCareer> CareerLists;
    public EndingCareerList(){
        CareerLists = new List<EndingCareer>();
        CareerLists.Add(new EndingCareer("Mathematician",1500,99999,0,99999,0,99999,0,99999,0,99999,30,new string[] {"Calculus I"}));


        CareerLists.Add(new EndingCareer("Software Engineer",1200,99999,0,99999,0,99999,0,99999,0,99999,50,new string[] {"User Interface Design"}));


        CareerLists.Add(new EndingCareer("Writer",0,99999,1500,99999,0,99999,0,99999,0,99999,30,new string[] {"Rhetoric I"}));


        CareerLists.Add(new EndingCareer("Drawer",0,99999,0,99999,1500,99999,0,99999,0,99999,30,new string[] {"Sketch I"}));

        CareerLists.Add(new EndingCareer("Basketball Coach",0,99999,0,99999,0,99999,0,99999,1500,99999,100,new string[] {"Three-step layup"}));

        CareerLists.Add(new EndingCareer("Scientist",1200,99999,0,99999,0,99999,1200,99999,0,99999,40,new string[] {"Organic Chemistry"}));

        CareerLists.Add(new EndingCareer("Spanish Teacher",0,99999,0,99999,0,99999,1200,99999,0,99999,30,new string[] {"Spanish Daily I"}));

    }
}
