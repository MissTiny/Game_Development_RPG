using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//把此脚本挂到Camera上， 可以让相机跟随一个指定GameObject 
//运行此脚本需要：
//          1. 在外部（unity editor里）指定此脚本的followObject
public class cameraFollow : MonoBehaviour
{
    public GameObject followObject;
    private Transform target;
    //private Vector3 offset;

    Vector3 previous_position;
    Vector3 dir;
    bool right_collider = false;
    bool left_collider = false;
    bool bottom_collider = false;
    bool up_collider = false;
    //bool collide = false;
    // Use this for initialization
    void Start()
    {
        target = followObject.transform;
        //Debug.Log(offset);
        //offset = target.position - this.transform.position;
        previous_position = target.position;
    }

    // Update is called once per frame
    void Update()
    {

        var movement = target.position -previous_position;
        Debug.Log($"{right_collider},{left_collider},{bottom_collider},{up_collider}");
        if (right_collider & movement.x>0){
            movement.x = 0;
        } else if(right_collider & movement.x <0){
            if(!left_collider){
                right_collider = false;
            }
        }
        if(left_collider & movement.x < 0){
            movement.x = 0;
        }else if(left_collider & movement.x >0){
            if(!right_collider){
                left_collider = false;
            }
        }
        if (bottom_collider & movement.y <0){
            movement.y = 0;
        }else if(bottom_collider & movement.y >0){
            if(!up_collider){
                bottom_collider = false;
            }
        }
        if (up_collider & movement.y >0){
            movement.y = 0;
        }else if(up_collider & movement.y <0){
            if(! bottom_collider){
                up_collider = false;
            }
        }
        this.transform.position = this.transform.position + movement;
        previous_position = target.position;
        dir = movement;

        
        //Debug.Log(offset);
        /*
        if(movement.x < 0 & right_collider & !left_collider){
            this.transform.position = target.position - offset;
        }else if(movement.x > 0 & left_collider & !right_collider){
            this.transform.position = target.position - offset;
        }
        if(movement.x < 0 & right_collider & !left_collider){
            this.transform.position = target.position - offset;
        }else if(movement.x > 0 & left_collider & !right_collider){
            this.transform.position = target.position - offset;
        }

        if(!right_collider & !left_collider & !bottom_collider & !up_collider){
            this.transform.position = target.position - offset;
        }
        */
        
        
    }

    void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log(collision.tag);
        if (collision.tag == "Boundary"){
            Debug.Log("Collide");
            
            Debug.Log(dir);
            if(dir.y > 0){
                up_collider = true;
            //Debug.Log("Collide up");
            }else if(dir.y < 0){
                bottom_collider = true;
                //Debug.Log("Collide bottom");
            }
            if(dir.x > 0){
                right_collider = true;
                //Debug.Log("Collide right"); 
            }else if(dir.x < 0){
                left_collider = true;
                //Debug.Log("Collide left");
            }
        }
        
        
        
		
	}

}
