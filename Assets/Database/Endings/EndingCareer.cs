using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCareer
{
    public string Name;
    public int Level;
    public int MiniIQ;
    public int MaxIQ;
    public int MiniEQ;
    public int MaxEQ;
    public int MiniImagination;
    public int MaxImagination;
    public int MiniMemory;
    public int MaxMemory;
    public int MiniCharm;
    public int MaxCharm;
    public int Money;
    public string[] CourseName;


    public EndingCareer(string name,int level, int miniiq,int maxiq,int minieq,int maxeq, int miniimagination,int maximagination, int minimemory, int maxmemory, int minicharm, int maxcharm, int money, string[] course){
        Name = name;
        Level= level;
        MaxImagination = maximagination;
        MaxIQ = maxiq;
        MaxMemory = maxmemory;
        MaxCharm = maxcharm;
        MaxEQ = maxeq;

        MiniCharm = minicharm;
        MiniIQ = miniiq;
        MiniEQ = minieq;
        MiniMemory = minimemory;
        MiniImagination = miniimagination;
        Money=money;
        CourseName = course;



    }

    
}
