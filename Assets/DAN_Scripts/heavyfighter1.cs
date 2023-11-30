using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heavyfighter1 : MonoBehaviour


{
    public float health = 100;
    
    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        
        {
            ParticleSystem heavyfighter1 = GetComponent<ParticleSystem>();
            heavyfighter1.Play();

            AudioSource explosion1 = GetComponent<AudioSource>();

            GetComponent<AudioSource>().Play();

            GetComponent<BoxCollider>().enabled = false;

            GetComponent<Renderer>().enabled = false;

            Destroy(gameObject, heavyfighter1.main.duration);
        }
             
    }

    
}