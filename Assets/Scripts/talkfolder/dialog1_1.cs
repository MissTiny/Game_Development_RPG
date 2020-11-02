using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;



public class dialog1_1 : MonoBehaviour
{
    [Header("UI")]
    public Text textlabel;
    public GameObject courseUI;
    public CourseList Course = new CourseList();
    public Text coursename;


    [Header("textfile")]
    public TextAsset txtfile;
    public int index;
    public bool st = false;


    List<string> textlist = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        Gettextfromfile(txtfile);
        
    }
    private void OnEnable()
    {
        textlabel.text = textlist[index];
    }
    // Update is called once per frame
    void Update()
    {
        //if((Input.GetKeyDown(KeyCode.F))&& index == textlist.Count)
        if ((Input.GetKeyDown(KeyCode.F)) && index == 6 || index == 9)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        if ((Input.GetKeyDown(KeyCode.F)) && index == 3)
        {
            //gameObject.SetActive(false);
            courseUI.SetActive(true);
           // Debug.Log(Course.Courses[0]);
           if(Ability.IQ == 20)
            {
               coursename.text = Course.Courses[1].CourseName;
            }
            coursename.text = Course.Courses[0].CourseName;
            
            index = 4;
            st = true;
           
            //return;
        }
        if ((Input.GetKeyDown(KeyCode.Y)) && st==true)

        {
             Ability.IQ += 10;
            //coursename.text = "class start";       
            courseUI.SetActive(false);
            index = 5;

        }
        if ((Input.GetKeyDown(KeyCode.N)) && st == true)
        {
            courseUI.SetActive(false);
            index = 7;

            
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            textlabel.text = textlist[index];
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
