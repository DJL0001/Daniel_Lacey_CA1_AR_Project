using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script originated from the Youtube video "Bullet Projectile With Particle System - Unity Tip" - https://www.youtube.com/watch?v=lkq8iLOr3sw

// This line of code defines a new class called "fighter1" and it is public so it can be accessed from outside the script.
public class fighter1 : MonoBehaviour


{
    // This is the amount of health that the fighter1 class has. It is a public float variable called "health" that will take damage when a bullet particle hits fighter1.  Because it is a public float I can edit the health amount in the inspector.
    public float health = 100;
    
    // This is a public function declared as "TakeDamage". It uses the "damage" parameter from the "public float damage" which was declared in the "ParticleBulletCollision". The "damage" float is set to 10.
    public void TakeDamage(float damage)
    {
        // This subtracts the 10f damage from the health declared above
        health -= damage;

        // This is an "if" statement that checks if the health is less than or equal to zero
        if(health <= 0)
        
        // If the health is equal to or less than zero then the following gets implemented:
        {
            // This gets the ParticleSystem component that is attached to the "fighter1" GameObject and stores it as a variable called "fighter1"
            ParticleSystem fighter1 = GetComponent<ParticleSystem>();
            
            // This plays the fighter1 particle system component
            fighter1.Play();
            
            // This gets the AudioSource component that is attached to the "fighter1" GameObject and then stores it as a variable called "explosion1".
            AudioSource explosion1 = GetComponent<AudioSource>();
            
            // This plays the audio source component which is an explosion sound.
            GetComponent<AudioSource>().Play();

            // This disables the box collider on the fighter1 GameObject. I did this to stop the ship from being hit again by the particle bullets after the destruction sequence has started because further hits were triggering more explosions
            GetComponent<BoxCollider>().enabled = false;

            // This line disables the renderer when the health of "fighter1" reaches zero. I implemented this because the ship was still visible after the explosion sequence was completed. As soon as the health reaches zero the renderer component for this GameObject is disabled which makes the ship disappear immediately.
            GetComponent<Renderer>().enabled = false;

            // This destroys the "fighter1" GameObject from the scene after the full duration of the explosion particle system component "fighter1" sequence.
            Destroy(gameObject, fighter1.main.duration);
        }
             
    }

    
}