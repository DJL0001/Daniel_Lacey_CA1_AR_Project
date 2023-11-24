using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSpinUpSound : MonoBehaviour
{
    
    AudioSource minigunSpinUp;
    
    // Start is called before the first frame update
    void Start()
    {
        minigunSpinUp= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play_minigunSpinUp()
    {
        minigunSpinUp.Play();
    }

} 
