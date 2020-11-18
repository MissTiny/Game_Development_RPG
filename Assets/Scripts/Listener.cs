using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    // Start is called before the first frame update
    public static Listener instance;
    public GameObject submenu;
    private GameObject temp_submenu;
    private bool submenu_stat = false;
    private static float Bgm_volume;
    private static float Walk_volume;
    private static float Click_volume;
    private static float Current_Bgm_volume;
    private static float Current_Walk_volume;
    private static float Current_Click_volume;
    public static int Ending_date = 3;
    private static int Current_date;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            Bgm_volume = AudioManager.instance.getVolume("Background");
            Walk_volume = AudioManager.instance.getVolume("Walk");
            Click_volume = AudioManager.instance.getVolume("Button Click");
            Current_Bgm_volume = 5;
            Current_Click_volume = 5;
            Current_Walk_volume = 5;
            Current_date = 0;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && submenu_stat == false)
        {
            temp_submenu = Instantiate(submenu);
            submenu_stat = !submenu_stat;
            submenu.SetActive(submenu_stat);
        }else if(Input.GetKeyDown(KeyCode.Escape) && submenu_stat == true)
        {
            Destroy(temp_submenu);
            submenu_stat = !submenu_stat;
        }
        if(Current_date > Ending_date)
        {
            Application.LoadLevel(7);
        }
    }
    public static void setCurrent_Bgm_volume(float volume)
    {
        Current_Bgm_volume = volume;
    }
    public static void setCurrent_Walk_volume(float volume)
    {
        Current_Walk_volume = volume;
    }
    public static void setCurrent_Click_volume(float volume)
    {
        Current_Click_volume = volume;
    }
    public static float getCurrent_Bgm_volume()
    {
        return Current_Bgm_volume;
    }
    public static float getCurrent_Walk_volume()
    {
        return Current_Walk_volume;
    }
    public static float getCurrent_Click_volume()
    {
        return Current_Click_volume;
    }
    public static void addDate()
    {
        Current_date++;
    }
}
