using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float movementSpeed = 1f;
    [SerializeField] Rigidbody2D rigidBody;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //input

        movement.x = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        //actual movement
        rigidBody.MovePosition(rigidBody.position + movement * movementSpeed * Time.fixedDeltaTime);
        
    }
}
