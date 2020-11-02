using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//把此脚本挂到Camera上， 可以让相机跟随一个指定GameObject 
//运行此脚本需要：
//          1. 在外部（unity editor里）指定此脚本的followObject
//          2. 手动设置Camera的运行边界，
//                           相机能去的最左下角点的Transform postition为minPosition
//                           相机能去的最右上角点的Transform postition为maxPosition
public class cameraFollow : MonoBehaviour
{

    public Transform followObject;
    //Camera boundary,
    public bool freeMove = true;
    public Vector2 minPosition;
    public Vector2 maxPosition;
    private float smooth = 0.03f;
    //private Vector3 offset;
    //hello

    //bool collide = false;
    // Use this for initialization
    void Start()
    {

        //mycam = GetComponent<Camera>();
        //Debug.Log(offset);
        //offset = target.position - this.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = followObject.position;
        //set boundary
        if (!freeMove)
        {
            targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);
        }
        //mycam.orthographicSize = 5f;
        //Debug.Log($"{right_collider},{left_collider},{bottom_collider},{up_collider}");
        transform.position = Vector3.Lerp(transform.position, targetPos, smooth) + new Vector3(0, 0, -10);


    }

    void OnTriggerEnter2D(Collider2D collision)
    {





    }

}
