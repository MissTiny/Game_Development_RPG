using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charater : MonoBehaviour
{
    private string name;
    private int faverable;
    private List<string> dialog;
    private Dictionary<string,int> hobby;

    public Charater(string name, List<string> dialog, Dictionary<string, int> hobby)
    {
        this.name = name;
        this.dialog = dialog;
        this.hobby = hobby;
        this.faverable = 0;
    }
    public string getName()
    {
        return name;
    }
    public void addDialog(string d)
    {
        dialog.Add(d);
    }
    public List<string> getDialog()
    {
        return dialog;
    }
    public Dictionary<string, int> getHobby()
    {
        return hobby;
    }
    public void addFaverable(int n)
    {
        faverable += n;
    }
    public int getFaverable()
    {
        return faverable;
    }
}
