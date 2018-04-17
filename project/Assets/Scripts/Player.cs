using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Animator anim;
    public static bool attack = false;
    /*private float inputH;
    private float inputV;
    private bool run;*/
    SphereCollider sphereCollider;
    public Rigidbody rbody;
    EnemyHealth enmeyH;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        rbody = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
        enmeyH = GetComponent<EnemyHealth>();
       // run = false;
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetBool("Attack", true);
        if (Input.GetKeyDown("1"))
        {
            anim.Play("WAIT04",-1,0f); 
           // anim.SetBool("Attack", true);

        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", -1, 0f);
            // anim.SetBool("Attack", true);

        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", -1, 0f);
            // anim.SetBool("Attack", true);

        }
        if (sphereCollider.isTrigger)
        {
            //enmeyH.TakeDamage(1);
            attack = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
