using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;



public class newdialog : MonoBehaviour
{
    [Header("UI")]
    public Text textlabel;
    public Text Name;
    public GameObject btn_panel;

    [Header("textfile")]
    //public TextAsset txtfile;
    public static int index;

    public int indexOfcharater;
     Character_list cl = new Character_list();

     

    List<string> textlist = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        index = 0;
        //Gettextfromfile(txtfile);
        Name.text = cl.charaters[indexOfcharater].getName();


    }
    private void OnEnable()
    {
        textlabel.text = cl.charaters[indexOfcharater].getDialog()[index];
        index++;
        
    }
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && index == cl.charaters[indexOfcharater].getDialog().Count)
        {
            //gameObject.SetActive(false);
            if (!btn_panel.activeSelf)
            {
                btn_panel.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.F) && index < cl.charaters[indexOfcharater].getDialog().Count)
        {
            var dialogs = cl.charaters[indexOfcharater].getDialog();
           // textlabel.text = textlist[index];
            textlabel.text = cl.charaters[indexOfcharater].getDialog()[index];
            index++;
        }
    }
    private void OntriggerExit2D(Collider2D other)
    {

    }
    void Gettextfromfile(TextAsset file)
    {
        textlist.Clear();
        index = 0;
        //file.text.Split('\n');
        var linedata = file.text.Split('\n');
        foreach (var line in linedata)
        {
            textlist.Add(line);
        }
    }

}

