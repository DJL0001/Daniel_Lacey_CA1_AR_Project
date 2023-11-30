using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchFiring : MonoBehaviour
{
    bool isFiring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void pointerDown()
    {
        isFiring = true;
    }

    public void pointerUp()
    {
        isFiring = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isFiring)
        {
            Debug.Log("FiringYEEHAAA");
        }
    }
}
