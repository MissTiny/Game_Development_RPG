using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TaskOnClick()
    {
        AudioManager.instance.Play("Button Click");
        Data data = SaveSystem.Load();
        Ability.AbilityLoad(data.IQ, data.EQ, data.Imagination, data.Memory, data.Charm, data.Pressure, data.Energy, data.Day);
    }
}
