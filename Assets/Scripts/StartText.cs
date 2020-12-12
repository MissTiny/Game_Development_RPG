using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StartText : MonoBehaviour
{
    Text startText;
    // Start is called before the first frame update
    void Start()
    {   startText = GetComponent<Text>();
        if(Listener.isFirstG){
            startText.text =
$@"You come from nowhere!Someone leaves you a home and pays your tuition for high school.

Now study hard, earn your future and ... your children's future.

You will receive ${Ability.dailymoney} daily to cover your spending.";

        }else{
            startText.text =
$@"Your parents work hard to provide you a bright future.

Now study hard to meet your parents' expectation and earn your life.

Your parents decide to give you ${Ability.dailymoney} a day.";
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
