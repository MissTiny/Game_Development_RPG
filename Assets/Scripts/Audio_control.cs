using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_control : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public Toggle Click_volume;
    public Slider slider_bgm;
    public Slider slider_walk;
    public void Start()
    {
        if(Listener.getCurrent_Click_volume() != 0)
        {
            Click_volume.isOn = true;
        }
        else
        {
            Click_volume.isOn = false;
        }
        slider_bgm.value = Listener.getCurrent_Bgm_volume();
        slider_walk.value = Listener.getCurrent_Walk_volume();
    }
    public void Update()
    {
        //TaskOnClick();
    }
    public void TaskOnClick()
    {
        if (this.Click_volume.isOn)
        {
            if (AudioManager.instance.isPlaying("Button Click") == false)
            {
                AudioManager.instance.setVolume("Button Click", 5);
                Click_volume.isOn = true;
            }
        }
        else
        {
            AudioManager.instance.setVolume("Button Click", 0);
            Click_volume.isOn = true;
        }
    }
    public void TaskOnSlider_bgm()
    {
        float new_volume = this.slider_bgm.value / 10;
        Debug.Log(new_volume);
        AudioManager.instance.setVolume("Background", new_volume);
        Debug.Log(AudioManager.instance.getVolume("Background"));
        Listener.setCurrent_Bgm_volume(this.slider_bgm.value);
    }
    public void TaskOnSlider_Walk()
    {
        float new_volume = this.slider_walk.value / 10;
        AudioManager.instance.setVolume("Walk", new_volume);
        Listener.setCurrent_Walk_volume(this.slider_walk.value);
    }

}
