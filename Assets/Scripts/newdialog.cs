using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;



public class newdialog : MonoBehaviour
{
    [Header("UI")]
    public Text textlabel;

    [Header("textfile")]
    //public TextAsset txtfile;
    public int index;
     Character_list cl = new Character_list();

     

    List<string> textlist = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {

        //Gettextfromfile(txtfile);
        


    }
    private void OnEnable()
    {
        textlabel.text = cl.charaters[0].getDialog()[0];
    }
    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && index == cl.charaters[0].getDialog().Count)
        {
            gameObject.SetActive(false);
            index = 1;
            return;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            var dialogs = cl.charaters[0].getDialog();
           // textlabel.text = textlist[index];
            textlabel.text = cl.charaters[0].getDialog()[index];
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

