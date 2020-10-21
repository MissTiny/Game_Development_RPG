using UnityEngine;
using System.Collections;
//将任何物体变成可用wasd控制的可动物体
//为了让此脚本正常运行需要：
//                1. 设置wasd上下左右4方向的animation clip 构成blender tree
             //   2. 4方向的animation idle clip, 状态机里由trigger触发，用来保留角色移动后的朝向
//                3. 物体object需要add Rigit2D 组件
//ctl + k   ctl+c   | ctl+k ctl+u
public class movable : MonoBehaviour
{
    private Animator animator;
    public int walkspeed;
    string dir = "left";      //0 up  1 down 2 left 3 right
    //string walkdir = "left";
    Vector3 new_dir;
    bool right_collider = false;
    bool left_collider = false;
    bool bottom_collider = false;
    bool up_collider = false;

    //bool collide = false;
    void Start()
    {

        animator = GetComponent<Animator>();

    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);
        if(movement.x != 0 ){
            movement.y = 0;
        }
        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        if (bottom_collider & movement.y < 0){
           movement.y = 0;
        } else if (bottom_collider & movement.y > 0){
            bottom_collider = false;
        }
        if (up_collider & movement.y < 0){
            up_collider = false;
        } else if (up_collider & movement.y > 0){
            movement.y = 0;
        }
        if (right_collider & movement.x > 0){
            movement.x = 0;
        } else if (right_collider & movement.x < 0){
            right_collider = false;            
        }
        if (left_collider & movement.x > 0){
            left_collider = false;
        } else if (left_collider & movement.x < 0){
            movement.x = 0;
        }
        new_dir = movement;
        transform.position = transform.position + movement*walkspeed * Time.deltaTime;

        WalkControl();
        
        if (movement.magnitude <0.1) {
            animator.SetTrigger(dir);
            
        }
        //good morning
        //Debug.Log(dir);
        //animator.SetTrigger(dir);
    }
    
    

    private void WalkControl()
    {
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
    }

	void OnTriggerEnter2D(Collider2D collision)
	{

        if(collision.tag != "MainCamera"){
            Debug.Log("Boundary hit");
            /*
            if (dir =="down"){
                bottom_collider = true;
                Debug.Log("Collide bottom");
            }
            if(dir =="up"){
                up_collider = true;
                Debug.Log("Collide up");
            }
            if(dir =="right"){
                right_collider = true;
                Debug.Log("Collide right");
            }
            if(dir =="left"){
                left_collider = true;
                Debug.Log("Collide left");
            }*/
            if(new_dir.y > 0){
                up_collider = true;
                //Debug.Log("Collide up");
            }else if(new_dir.y < 0){
                bottom_collider = true;
                //Debug.Log("Collide bottom");
            }else if(new_dir.x > 0){
                right_collider = true;
                //Debug.Log("Collide right"); 
            }else if(new_dir.x < 0){
                left_collider = true;
                //Debug.Log("Collide left");
            }
        }
        

        if(collision.tag=="CorridorEnter"){
            Application.LoadLevel(2);
        }
        else if(collision.tag == "HomeEnter")
        {
            Application.LoadLevel(1);
        }
        else if (collision.tag == "ClassroomEnter")
        {
            Application.LoadLevel(3);
        }
        else if (collision.tag == "LibraryEnter")
        {
            Application.LoadLevel(4);
        }
        else if (collision.tag == "MusicroomEnter")
        {
            Application.LoadLevel(5);
        }


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

