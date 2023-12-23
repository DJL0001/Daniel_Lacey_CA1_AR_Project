using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Tutorials used - "Enemy Movement - Unity 3D Game Development: Week 3 Game - https://youtu.be/pRyI_1QlEak?si=mXCLa_FhSAo57PiU

// This declares a public class called "EnemyMovement"
public class EnemyMovement : MonoBehaviour
{
    // This declares a public variable called "target" which is of the "Transform" type and marks it as serializable which means there will be a field in the inspector where I can drag and drop a target GameObject. The player will be the game object so the enemies will move towards the player.
    [SerializeField]Transform target;

    // Declare a public float called "movementSpeed" and it is set to 10f which means that the enemy will move at 10 units per second. It is also serializable which means a field will be exposed in the inspector for me to input whatever speed I want the enemies to move at.
    [SerializeField]float movementSpeed = 10f;

    // This declares a public float called "rotationalDamp" which will affect how smoothly the enemy ships will turn. It is serializable so I can input an appropriate number in the exposed field.
    [SerializeField]float rotationalDamp = .5f;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This calls the "Turn" method which will rotate the enemy ship towards its target.
        Turn();

        // This calles the "Move" method which moves the enemy ship forward.
        Move();
    }

    // This declares the private method "Turn" 
    void Turn()
    {
        // This declares a variable of type "Vector3" called "pos" and assigns it the difference between the position of the target and the enemy ship's position
        Vector3 pos = target.position - transform.position;

        // This declares a variable of type "Quaternion" called "rotation" and assigns it the result of the "LookRotation" method on the "pos" vector which stores the rotation of the enemy that is needed so that it faces the target
        Quaternion rotation = Quaternion.LookRotation(pos);

        // This sets the rotation of the enemy to the result of the "Slerp" method on the current rotation, the rotation that is needed and the result of the rotationalDamp multiplied by the delta time. This basically creates a smooth transition from the current rotation of the enemy ship to the rotation that is needed.
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationalDamp * Time.deltaTime);
    }

    // This declares the private method named "Move"
    void Move()
    {
        // This will add the result of the enemy ships forward direction multiplied by its movement speed multiplied by the delta time. This has the effect of making the enmy ship move forward at a constant speed. In this current state it makes ships circle the player. 
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
