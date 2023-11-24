using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Minigun_1 : MonoBehaviour
{
    public Animator animator; // The Mecanim animator controller

    private void Start()
    {
        // Set the animator's idle state
        animator.SetInteger("default", 0);
    }

    private void Update()
    {
        // If the player presses the fire button, start the spin-up animation
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetInteger("fullspin", 1);
        }

        // If the player releases the fire button, stop the minigun from firing
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetInteger("default", 0);
        }
    }
}

























// public class PlayMinigunAnim : MonoBehaviour
// {
    
//    public Animator animator; 
//     // Start is called before the first frame update
//    private void Start()
//     {
//         animator.SetInteger("State", 0); 
//     }

//     // Update is called once per frame
//     private void Update()
//     {
//         if (Input.GetButtonDown("space"))
//         {
//             animator.SetInteger("State", 1);
//         }

//         if (Input.GetButtonUp("space"))
//         {
//             animator.SetInteger("State", 0);
//         }
//     }
// }

