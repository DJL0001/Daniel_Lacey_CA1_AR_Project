/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletParticles : MonoBehaviour
{
    public ParticleSystem partsys;

    List<ParticleCollisionEvent> colEvents = new List<ParticleCollisionEvent>();

    private void Start()
    {
        partsys = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            partsys.Play();
        }

        else
        {
            partsys.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        int events = partsys.GetCollisionEvents(other, colEvents);

        Debug.Log("Hit");
        
        for (int i = 0; i < events; i++)
        {

        }
    }

}
 */