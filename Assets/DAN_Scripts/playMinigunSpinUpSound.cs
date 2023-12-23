using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tutorial referenced for this script - "Sync sound and Animation in Unity using Animation Event" - https://www.youtube.com/watch?v=OZwbg9Jam-Q


// This declares a public class called "playSpinUpSound".
public class playSpinUpSound : MonoBehaviour
{
    // This declares a private variable of the type "AudioSource" called minigunSpinUp.
    AudioSource minigunSpinUp;
    
    // Start is called before the first frame update
    void Start()
    {
        // This gets the component "AudioSource" and assigns it to "minigunSpinUp"
        minigunSpinUp= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This declares a public method called "play_minigunSpinUp". This will be referenced by an event on the Mecanim timeline.
    public void play_minigunSpinUp()
    {
        // This calls the "Play" method on the minigunSpinUp variable which will play the audio clip assigned to the AudioSource component on the GameObject.
        minigunSpinUp.Play();
    }

} 
