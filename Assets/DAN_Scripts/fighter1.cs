using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter1 : MonoBehaviour


{
    public float health = 100;
    
    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        
        {
            ParticleSystem fighter1 = GetComponent<ParticleSystem>();
            fighter1.Play();

            AudioSource explosion1 = GetComponent<AudioSource>();

            GetComponent<AudioSource>().Play();

            GetComponent<BoxCollider>().enabled = false;

            GetComponent<Renderer>().enabled = false;

            Destroy(gameObject, fighter1.main.duration);
        }
             
    }

    
}