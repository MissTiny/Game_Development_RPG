using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Ability
{
    // Start is called before the first frame update
    public static int IQ = 0;
    public static int EQ = 0;
    public static int Imagination = 0;
    public static int Memory = 0;
    public static int Charm = 0;
    public static int Pressure = 0;
    public static int Energy = 100;

    public static int dailymoney = 15;
    public static int moneyTotal =100;
    // Update is called once per frame
    /*
    public Ability(int iq, int eq, int imagination, int memory, int charm, int pressure, int energy, int day){
        IQ = iq;
        EQ = eq;
        Imagination = imagination;
        Memory = memory;
        Charm = charm;
        Pressure = Pressure;
        Energy = energy;
        Day = day;
    }
    */
    public static void AbilityLoad(int iq, int eq, int imagination, int memory, int charm, int pressure, int energy){
        IQ = iq;
        EQ = eq;
        Imagination = imagination;
        Memory = memory;
        Charm = charm;
        Pressure = pressure;
        Energy = energy;
    }
    public static int getIQ(){
        return IQ;
    }
    public static int updateIQ(int iq){
        IQ = iq;
        return IQ;
    }
    public static int getEQ(){
        return EQ;
    }
    public static int updateEQ(int eq){
        EQ = eq;
        return EQ;
    }
    public static int getImagination(){
        return Imagination;
    }
    public static int updateImagination(int imagination){
        Imagination = imagination;
        return Imagination;
    }
    public static int getMemory(){
        return Memory;
    }
    public static int updateMemory(int memory){
        Memory = memory;
        return Memory;
    }
    public static int getCharm(){
        return Charm;
    }
    public static int updateCharm(int charm){
        Charm = charm;
        return Charm;
    }
    public static int getPressure(){
        return Pressure;
    }
    public static int updatePressure(int pressure){
        Pressure = pressure;
        return Pressure;
    }
    public static int getEnergy(){
        return Energy;
    }
    public static int updateEnergy(int energy){
        Energy = energy;
        return Energy;
    }
}
