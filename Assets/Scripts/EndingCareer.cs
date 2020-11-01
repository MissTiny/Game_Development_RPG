using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCareer
{
    public string Name;
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
    public string[] CourseName;

    public EndingCareer(string name, int miniiq,int maxiq,int minieq,int maxeq, int miniimagination,int maximagination, int minimemory, int maxmemory, int minicharm, int maxcharm, string[] course){
        Name = name;
        
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

        CourseName = course;



    }

    
}
