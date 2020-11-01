using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//此脚本被挂在Attackable prefab上，任何此prefab的父物体将获得攻击和被攻击的能力
//物体的攻击范围和受伤范围可以用prefab的子元素AttackRange，和HurtRange来自定义
//注意：1. 父物体需要有能用“Attack”触发的animation clip

public class Attackable : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int attackPower;
    //标识它是攻击者还是攻击对象
    private bool isAttacker;
    private GameObject parent;
    private Animator animator;
    private bool finish;
    public void Start()
    {
        isAttacker = false;
	finish = true;
        parent = this.transform.parent.gameObject;
        animator = parent.GetComponent<Animator>();
        disableCollider();
    }

    // Update is called once per frame
    public void Update()
    {
        if (health <= 0)
        {
            //replace following with die animation 
            Destroy(parent);
        }
        //如果是玩家，才需要响应键盘输入
        if (parent.tag == "Player" && Input.GetKey(KeyCode.J))
        {
	    if(finish){
		 Attack();
	    }
            
        }

    }

    public void lossHealth(int damage)
    {
        health -= damage;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        //攻击有效的条件是：1.我是攻击者，而不是被攻击的 2.我攻击的是能受伤范围
        if (isAttacker)
        {
            if (other.name == "HurtRange")
            {
                Attackable o = other.GetComponentInParent<Attackable>();
                if (o != null)
                {
                    o.lossHealth(attackPower);
                }
            }
        }
        isAttacker = false;

    }
    private void disableCollider()
    {
        if (GetComponent<BoxCollider2D>() != null) GetComponent<BoxCollider2D>().enabled = false;
        //if (GetComponent<PolygonCollider2D>()!=null) GetComponent<PolygonCollider2D>().enabled = false;
    }
    private void enableCollider()
    {
        if (GetComponent<BoxCollider2D>() != null) GetComponent<BoxCollider2D>().enabled = true;
        //if (GetComponent<PolygonCollider2D>() != null) GetComponent<PolygonCollider2D>().enabled = true;
    }
    private void Attack()
    {
        enableCollider();
        isAttacker = true;
        animator.SetTrigger("Attack");
	finish = false;
        //如果是一个可上下左右移动的物体，我们得知道它的攻击方向
        movable m = parent.GetComponent<movable>();
        if (m != null)
        {
            animator.SetTrigger(m.getDir());
        }
        StartCoroutine(disable());
    }

    IEnumerator disable()
    {
        yield return new WaitForSeconds(0.5f);
        disableCollider();
	finish = true;
    }

    private void OnMouseOver()
    {

        return;
    }

    private void OnMouseExit()
    {
        return;
    }

}

