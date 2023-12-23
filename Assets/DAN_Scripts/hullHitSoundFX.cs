using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tutorials used to create this script
// How To Make A Random Audio Clip From An Array in Unity - https://www.youtube.com/watch?v=OCRzBX3ON_c
// #45 Play Random Sound From Array (Unity Top-Down Tutorial) - https://www.youtube.com/watch?v=nU7ivIWvfH8
// Random Audio in Unity : Sound Design Tutorial - https://www.youtube.com/watch?v=lqyzGntF5Hw


// This is a public class called "hullHitSoundFX".
public class hullHitSoundFX : MonoBehaviour
{
    // This declares a variable called "audioSource" that references the AudioSource component.
    public AudioSource audioSource;

    // This is a public AudioClip array called "hullHitSounds". This will expose fields in the inspector that will allow me to insert multiple different sound effects into it.
    public AudioClip[] hullHitSounds;

    // This declares a private method called "OnParticleCollision" and has a parameter called "other" which is a GameObject. This method is called when a particle system collides with the game object.
    private void OnParticleCollision(GameObject other)
    {
        // This declares an int called "randomSFX" and assigns it a random value which is between zero and the length of the hullHitSounds array which will have four different hit sound effects.
        int randomSFX = Random.Range(0, hullHitSounds.Length);

        // This calls the "PlayOneShot" method on the audioSource variable and passes it whatever audio clip is at the index of the "randomSFX" variable.  
        audioSource.PlayOneShot(hullHitSounds[randomSFX]);
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
