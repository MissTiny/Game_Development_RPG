using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCareerList 
{
    public List<EndingCareer> CareerLists;
    public EndingCareerList(){
        CareerLists = new List<EndingCareer>();
        CareerLists.Add(new EndingCareer("Mathematician",1500,99999,0,99999,0,99999,0,99999,0,99999,new string[] {"Calculus I"}));
    }
}
