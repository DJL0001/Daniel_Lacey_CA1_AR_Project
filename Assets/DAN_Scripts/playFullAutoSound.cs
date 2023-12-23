using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tutorial referenced for this script - "Sync sound and Animation in Unity using Animation Event" - https://www.youtube.com/watch?v=OZwbg9Jam-Q


// This declares a public class called "playFullAuto".
public class playFullAuto : MonoBehaviour
{
    // This declares a private variable of the type "AudioSource" called minigunFullAuto.
    AudioSource minigunFullAuto;
    
    // Start is called before the first frame update
    void Start()
    {
        // This gets the component "AudioSource" and assigns it to "minigunFullAuto"
        minigunFullAuto= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This declares a public method called "play_minigunFullAuto". This will be referenced by an event on the Mecanim timeline
    public void play_minigunFullAuto()
    {
        // This calls the "Play" method on the minigunFullAuto variable which will play the audio clip assigned to the AudioSource component on the GameObject.
        minigunFullAuto.Play();
    }
  
} 
