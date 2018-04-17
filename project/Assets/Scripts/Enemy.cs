using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private Transform player;
    public float attackDistance = 2;
    public float attackTime = 3;  
    private float attackCounter = 0;
    public float speed = 5;
    public Vector3 soomthdir = Vector3.zero;
    //Rigidbody rigidbody;
    Animation m_anim;
    UnityEngine.AI.NavMeshAgent nav;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
       
        m_anim = GetComponent<Animation>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        attackCounter = attackTime;
    }
    

    void Update()
    {

        Vector3 targetPos = player.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);
        float distance = Vector3.Distance(targetPos, transform.position);
        nav.SetDestination(targetPos);
        if (distance <= attackDistance)
        {
            attackCounter += Time.deltaTime;
            if (attackCounter > attackTime)
            {
                m_anim.Play("Attack Jump");
            }
            else
            {
                m_anim.Play("Walk");

            }
        }
       else
        {
            attackCounter = attackTime;
            m_anim.Play("Walk");
        }

    }
}
