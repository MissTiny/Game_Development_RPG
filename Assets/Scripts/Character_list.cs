using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_list : MonoBehaviour
{
    public List<Charater> charaters;
    
    public Character_list()
    {
        charaters.Add(new Charater("Emma", new List<string> { "Hello! What's up!"}, new Dictionary<string, int> { { "Book", 5 } }));
    }

   
}
