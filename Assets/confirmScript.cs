using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;


public class confirmScript : MonoBehaviour
{
    public GameObject canvas;
    public void OnClick()
    {
        canvas.SetActive(false);
        List<Course> Daliy_course_list = Listener.GetCourses();
        foreach (var item in Daliy_course_list)
        {
            if(item.Gain.ContainsKey("IQ")){
                Ability.IQ +=item.Gain["IQ"];
            }
            if(item.Gain.ContainsKey("EQ")){
                Ability.EQ +=item.Gain["EQ"];
            }
            if(item.Gain.ContainsKey("Charm")){
                Ability.Charm +=item.Gain["Charm"];
            }
            if(item.Gain.ContainsKey("Memory")){
                Ability.Memory +=item.Gain["Memory"];
            }
            if(item.Gain.ContainsKey("Imagination")){
                Ability.Imagination +=item.Gain["Imagination"];
            }
            if(item.Gain.ContainsKey("Pressure")){
                Ability.Pressure +=item.Gain["Pressure"];
            }
            if(item.Gain.ContainsKey("Energy")){
                Ability.Energy +=item.Gain["Energy"];
            } 
        }
    }

}
