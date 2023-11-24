using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playFullAuto : MonoBehaviour
{
    
    AudioSource minigunFullAuto;
    
    // Start is called before the first frame update
    void Start()
    {
        minigunFullAuto= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play_minigunFullAuto()
    {
        minigunFullAuto.Play();
    }
  
} 
