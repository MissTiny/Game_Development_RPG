using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class EndingText : MonoBehaviour
{
    Text endingText;
    // Start is called before the first frame update
    void Start()
    {
        EndingCareerList careers = new EndingCareerList();
        List<EndingCareer> results = new List<EndingCareer>();
        EndingCareer finalcareer;
        int level = 0;
        foreach (var career in careers.CareerLists)
        {
            if (career.MiniIQ > Ability.IQ || Ability.IQ > career.MaxIQ)
            {
                continue;
            }
            if (career.MiniEQ > Ability.EQ || Ability.EQ > career.MaxEQ)
            {
                continue;
            }
            if (career.MiniCharm > Ability.Charm || Ability.Charm > career.MaxCharm)
            {
                continue;
            }
            if (career.MiniMemory > Ability.Memory || Ability.Memory > career.MaxMemory)
            {
                continue;
            }
            if (career.MiniImagination > Ability.Imagination || Ability.Imagination > career.MaxImagination)
            {
                continue;
            }
            
            if (career.Level < level)
            {
                continue;
            }
            if (career.Level > level)
            {
                results.Clear();
                level = career.Level;
            }
            results.Add(career);
        }
        if (results.Count == 1)
        {
            finalcareer = results[0];
        }else{
            var random = new System.Random();
            int index = random.Next(results.Count);
            finalcareer = results[index];
        }
        endingText = GetComponent<Text>();
        endingText.text =
$@"As day passed, you graduated from the local high school and entered the college.You chose your favorate major and continued studying.You finally become a <b>[{finalcareer.Name}]</b> after graduate from the college.

When thinking of your life, you always wonder what the life would be like if you work harder in your high school.

After years of working, you know it is the time to find the one to marry with. You can't forget girls you meet in your high school. With the pressure from parents, you date with these girls. You end up married with no one.";






    }

    // Update is called once per frame
    void Update()
    {

    }
}
