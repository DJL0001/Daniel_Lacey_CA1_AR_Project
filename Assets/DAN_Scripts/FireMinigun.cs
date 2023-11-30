using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMinigun : MonoBehaviour

{
    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mAnimator != null)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                mAnimator.SetTrigger("openFire");
            }

            if(Input.GetKey(KeyCode.Space))
            {
                mAnimator.SetTrigger("sustainFire");
            }

            if(Input.GetKeyUp(KeyCode.Space))
            {
                mAnimator.SetTrigger("endFire");
            }

        }
    }
}
