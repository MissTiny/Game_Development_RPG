using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Data{
    //abilities
    public int IQ;
    public int EQ;
    public int Imagination;
    public int Memory;
    public int Charm;

    public int Pressure;
    public int Energy;
    public int Day;


    //add more to save as needed
    public Data(){
        IQ =Ability.IQ;
        EQ = Ability.EQ;
        Imagination = Ability.Imagination;
        Memory = Ability.Memory; 
        Charm = Ability.Charm;
        Pressure = Ability.Pressure;
        Charm = Ability.Charm;
        Pressure = Ability.Pressure;
        Energy = Ability.Energy;
        Day = Listener.Current_date;
    }
}
