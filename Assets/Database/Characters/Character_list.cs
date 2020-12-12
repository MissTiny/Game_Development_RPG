using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_list : MonoBehaviour
{
    public List<Charater> charaters;
    
    public Character_list()
    {
        charaters = new List<Charater>();
        charaters.Add(new Charater("Emma", new List<string> { "Hello! What's up!", "Have you watched the Show Last Night?" }, new Dictionary<string, int> { { "Cosmetic", 15 },{ "Music Record",10 }, { "Luxury Bag", 80 }, { "Phone", 60 }, { "Lucky Candy",0 } }));
        charaters.Add(new Charater("Isabella", new List<string> { "Hey, how was going!","It's a pleasant thing to read outside on a fine day, right?",  }, new Dictionary<string, int> { { "Book", 15 }, { "Snacks", 5 }, { "Luxury Bag", 80 }, { "Phone", 60 }, { "Lucky Candy", 0 } }));
        charaters.Add(new Charater("Ela", new List<string> { "Emm...", "What do you think of my new bag?", "It's the latest one. Do you kwon there is a new phone released?" }, new Dictionary<string, int> { { "Luxury Bag", 80 }, { "Phone", 60 }, { "Cosmetic", 12 }, { "Lucky Candy", 0 } }));

    }

   
}
