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
    void Start()
    {

        animator = GetComponent<Animator>();

    }
    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0.0f);
        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        transform.position = transform.position + movement*walkspeed * Time.deltaTime;
        WalkControl();
        if (movement.magnitude <0.1) {
            animator.SetTrigger(dir);
        }
        
    }
    
    

    private void WalkControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            dir = "up";

        }
        else if (Input.GetKey(KeyCode.A))
        {

            dir = "left";
        }
        else if (Input.GetKey(KeyCode.S))
        {

            dir = "down";
        }
        else if (Input.GetKey(KeyCode.D))
        {

            dir = "right";
        }
    }

    
}

