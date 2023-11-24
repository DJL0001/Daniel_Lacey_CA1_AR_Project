/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFullAutoSound : MonoBehaviour
{ 
    public AudioClip firstAudioClip;
    public AudioClip secondAudioClip;
    AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        AudioClip.PlayOneShot (firstAudioClip, 1f);
        AudioClip.PlayOneShot (secondAudioClip, 1f);
    }
    
    public void play_minigunIntro()
    {
        firstAudioClip.Play();
    }
    public void play_minigunFullAuto()
    {
        secondAudioClip.Play();
    }

}  */
