using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_list : MonoBehaviour
{
    public List<Charater> charaters;
    
    public Character_list()
    {
        charaters = new List<Charater>();
        charaters.Add(new Charater("Emma", new List<string> { "Hello! What's up!", "how are u today?","i love our school" }, new Dictionary<string, int> { { "Book", 5 } }));

    }

   
}
