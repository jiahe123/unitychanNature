using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int startingHealth = 5;             
    public int currentHealth;                  
    public float sinkSpeed = 2.5f;               
    //public int scoreValue = 10;                  
    //public AudioClip deathClip;                   


    Animation anim;                             
    AudioSource enemyAudio;                      
    ParticleSystem hitParticles;                 
    CapsuleCollider capsuleCollider;             
    bool isDead;                                 
    bool isSinking;                              


    void Awake()
    {
        // Setting up the references.
        anim = GetComponent<Animation>();
        enemyAudio = GetComponent<AudioSource>();
        /*hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider>();*/

        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;
    }

    void Update()
    {
        
        if (isSinking)
        {
           
            transform.Translate(-Vector3.up * sinkSpeed * Time.deltaTime);
        }
        if (Player.attack)
        {
            TakeDamage(1);
            //enemyAudio.Play();
            //print("d");
            

        }
        Player.attack = false;
    }


    public void TakeDamage(int amount)
    {
         
        if (isDead)
             
            return;

         
       // enemyAudio.Play();

         
        currentHealth -= amount;

        
        //hitParticles.transform.position = hitPoint;

         
        //hitParticles.Play();

         
        if (currentHealth <= 0)
        {
            // ... the enemy is dead.
            Death();
        }
    }


    void Death()
    {
         
        isDead = true;

   
        //capsuleCollider.isTrigger = true;

         
        //anim.SetTrigger("Dead");

         
       // enemyAudio.clip = deathClip;
        //enemyAudio.Play();
    }


    public void StartSinking()
    {
        // Find and disable the Nav Mesh Agent.
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;

         
        GetComponent<Rigidbody>().isKinematic = true;

        
        isSinking = true;

         
        //ScoreManager.score += scoreValue;

         
        Destroy(gameObject, 2f);
    }
}
