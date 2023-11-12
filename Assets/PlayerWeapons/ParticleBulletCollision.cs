using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleBulletCollision : MonoBehaviour

{
    public float damage = 10f;
    public ParticleSystem bulletParticle;

    public GameObject bulletHit;

    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();

    private void Update()
    {
       /*  if(Input.GetKeyDown(KeyCode.Space))
        {
            bulletParticle.Play();
        } */
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            bulletParticle.Play(); 
        }

        if (Input.GetKeyUp(KeyCode.Space)) 
        { 
            bulletParticle.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
       int events = bulletParticle.GetCollisionEvents(other, colEvents);
       
       /* for (int i = 0; i < events; i++)
       {
            Instantiate(bulletHit, colEvents[i].intersection, Quaternion.LookRotation(colEvents[i].normal))
       } */

        if(other.TryGetComponent(out EnemyTEST en))
        {
            en.TakeDamage(damage);
        }
    
    }
}


