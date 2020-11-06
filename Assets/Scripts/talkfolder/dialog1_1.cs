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
    public void CreateButton(Transform panel, Vector3 position, Vector2 size, UnityEngine.Events.UnityAction method)
    {
        GameObject button = new GameObject();
        button.transform.parent = panel;
        button.AddComponent<RectTransform>();
        button.AddComponent<Button>();
        button.transform.position = position;
        button.GetComponent<Button>().onClick.AddListener(method);
    }
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
           
            for(int i =0; i< Course.Courses.Count; i++)
            {
                if (Ability.IQ >= Course.Courses[i].MinimumIQ)
                {
                   
                    coursename.text += Course.Courses[i].CourseName;
                    coursename.text += "                       ";
                    
                }
            }
            //coursename.text = Course.Courses[0].CourseName;



            
            index = 4;
            st = true;
           
            //return;
        }
        if ((Input.GetKeyDown(KeyCode.Y)) && st==true)

        {
            Ability.IQ += Course.Courses[1].Gain["IQ"];
            //Ability.IQ += 50;
            //Debug.Log(Ability.IQ);
            //coursename.text = "class start";   
            coursename.text = "";
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
