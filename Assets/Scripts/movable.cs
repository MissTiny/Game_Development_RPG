using UnityEngine;
using System.Collections;
//将任何物体变成可用wasd控制的可动物体
//为了让此脚本正常运行需要：
//                1. 设置wasd上下左右4方向的animation clip 构成blender tree
//   2. 4方向的animation idle clip, 状态机里由trigger触发，用来保留角色移动后的朝向
//                3. 物体object需要add Rigid2D 组件
//ctl + k   ctl+c   | ctl+k ctl+u
public class movable : MonoBehaviour
{
    private Animator animator;
    public int walkspeed;
    string dir = "down";      //initail direction
    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }
    void Update()
    {




        WalkControl();


        //good morning
        //Debug.Log(dir);
        //animator.SetTrigger(dir);
    }





    private void WalkControl()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        Vector2 position = transform.position;

        if (movement.magnitude > 0)
        {
            position.x += movement.x * walkspeed * Time.deltaTime;
            position.y += movement.y * walkspeed * Time.deltaTime;
        }

        rbody.MovePosition(position);

        //transform.position = transform.position + movement * walkspeed * Time.deltaTime;
        if ((Input.GetKey(KeyCode.W) || Input.GetKey("up")))
        {
            dir = "up";

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey("left"))
        {

            dir = "left";
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey("down"))
        {

            dir = "down";
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey("right"))
        {

            dir = "right";
        }
        if (movement.magnitude <= 0)
        {
            animator.SetTrigger(dir);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "CorridorEnter")
        {
            Application.LoadLevel(3);
        }
        else if (collision.tag == "HomeEnter")
        {
            Application.LoadLevel(1);
        }
        else if (collision.tag == "ClassroomEnter")
        {
            Application.LoadLevel(4);
        }
        else if (collision.tag == "LibraryEnter")
        {
            Application.LoadLevel(5);
        }
        else if (collision.tag == "MusicroomEnter")
        {
            Application.LoadLevel(6);
        }


    }

    public string getDir()
    {
        return dir;
    }
    /*
    void OnTriggerStay2D(Collider2D collision){
        if (collision.tag == "Boundary"){
            Debug.Log("Boundary hit");
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);
            animator.SetFloat("Horizontal",movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Magnitude", movement.magnitude);
            //Debug.Log(movement.y);
            Debug.Log(dir);
            transform.position = transform.position - movement*walkspeed * Time.deltaTime;

         }

    }
    */



}