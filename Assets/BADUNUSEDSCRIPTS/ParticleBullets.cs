using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleFollowCamera : MonoBehaviour 
{
    public Camera arCamera;
    private Transform particleTransform;

    void Start()
    {
        particleTransform = GetComponent<Transform>();
    }

    void Update()
    {
        particleTransform.position = arCamera.transform.position;
        particleTransform.rotation = arCamera.transform.rotation;
    }

}
/* public class ParticleBullets : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
 */