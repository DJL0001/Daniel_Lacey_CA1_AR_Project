using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hullHitSoundFX : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip[] hullHitSounds;

    private void OnParticleCollision(GameObject other)
    {
        int randomIndex = Random.Range(0, hullHitSounds.Length);
        audioSource.PlayOneShot(hullHitSounds[randomIndex]);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
