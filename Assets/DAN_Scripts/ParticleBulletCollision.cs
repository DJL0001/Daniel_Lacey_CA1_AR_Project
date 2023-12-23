using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script originated from the Youtube video "Bullet Projectile With Particle System - Unity Tip" - https://www.youtube.com/watch?v=lkq8iLOr3sw 

// This line of code defines a new class called "ParticleBulletCollision" and it is public so it can be accessed from outside the script.
public class ParticleBulletCollision : MonoBehaviour

{   // This line of code declares a variable called "damage" and it is a "float" which is a decimal number. Its value is 10. 10 is the amount of damage each particle will cause when it hits an object.
    public float damage = 10f;
    
    // This line of code declares a public variable called "bulletParticle" which will represent the "ParticleSystem".
    public ParticleSystem bulletParticle;

    // This line of code declares a public variable called "bulletHit" and it is a GameObject.
    public GameObject bulletHit;
    
    // This line of code declares a private variable called "colEvents". It is a list of "ParticleCollisionEvent" objects. It stores information about collisions that happen between the ParticleSystem and GameObjects. A "List" is a generic collection that can store and manipulate items of the same type. In this particular instance the "List" deals with whatever is within the angle brackets which is "ParticleCollisionEvent". The "ParticleCollisionEvent" is a struct and it contains the aspects of a particle collision such as the velocity, position and normal of a collision.
    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();

    private void Update()
    {
        // This line of code starts an if statement which executes of a certain condition is true. The condition which will execute the "if" statement here is if the space key is pressed down during the current frame. I set this so as to test the firing of the particles within Unity. Another script called "touchFiring" is used to fire the particles using a button on the mobile touch screen. 
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            // This makes the bulletParticle system component play when the space key is depressed. 
            bulletParticle.Play(); 
        }

        // This line of code starts an if statement which executes of a certain condition is true. The condition which will execute the "if" statement here is if the space key is up during the current frame. I set this so as to test the firing of the particles within Unity. Another script called "touchFiring" is used to fire the particles using a button on the mobile touch screen. 
        if (Input.GetKeyUp(KeyCode.Space)) 
        { 
           // This makes the bulletParticle system component stop playing when the space key is not pressed. 
            bulletParticle.Stop();
        }
    }

    // This line of code defines a private function called OnParticleCollision which performs a task. It is called when a particle hits a collider. It is a void which means that it does not return any value. Its parameter is called "other" which is a GameObject. The OnParticleCollison function is called when a particle from the ParticleSystem collides with a GameObject.
    private void OnParticleCollision(GameObject other)
    {
        // This line of code declares an int variable called "events" which stores the number of collision events as an integer. "bulletParticle" references the particle system component. "GetCollisonEvents" that has two parameters: "other" which represents the GameObject that collided with the particle system and "colEvents" that holds a list of ParticleCollisionEvent objects. The number of events is returned as an integer and stored in events which will be used to apply the damage number to an enemy.
       int events = bulletParticle.GetCollisionEvents(other, colEvents);
       
        // "TryGetComponent" checks that the "other" GameObject has the component of type "fighter1" and will pass out "f1" as an out parameter. If the "fighter1" component is found it will assign it to the "f1" variable. If the "fighter1" is found then the "TakeDamage" method applies damage to the fighter1 component. The damage amount is declared as a public float at the start of the script.
        if (other.TryGetComponent(out fighter1 f1))
        {
            f1.TakeDamage(damage);
        }

        // This is exactly the same code as above except that it replaces "fighter1" with "heavyfighter1". There may be a better way of doing this besides listing every enemy in here and repeating the code.
        if (other.TryGetComponent(out heavyfighter1 hf1))
        {
            hf1.TakeDamage(damage);
        }
    
    }
}
