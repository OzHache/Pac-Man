using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { Up, Down, Left, Right}

public class PlayerMovement : MonoBehaviour
{
    Direction facing;
    public float speed;
    [Header("Gizmo Line Lenght")]
    public float lineLenght; 


    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //check for input
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            GetDirection();
            //rotate
            RotatePacMan();
            //See if we can go that way
            RaycastHit2D hit = 
            Physics2D.Raycast(transform.position, transform.right, lineLenght);
            Debug.Log(hit.collider.name);
            //todo: Manage collisions - 
            //move that direction
            MoveCharacter();
        }

    }
    private void OnDrawGizmos()
    {
        /*
         * In order to see how far our raycast should check we are going to 
         * create a gizmo called Draw Line
         * Then we will create a variable that we can slide to determine how 
         * long the line should be
         */
        Gizmos.DrawLine(transform.position, transform.position + 
        (transform.right * lineLenght));

    }

    private void MoveCharacter()
    {
        //need speed
        //need reference to a rigidbody
        rb.velocity = transform.right * speed;

    }

    private void RotatePacMan()
    {
        //Rotate based on which way I am facing
        var rotationDirection = new Dictionary<Direction, int>()
        {
            {Direction.Right, 0},
            {Direction.Up, 90},
            {Direction.Left, 180},
            {Direction.Down, 270}
        };
        transform.rotation = Quaternion.Euler(Vector3.forward * rotationDirection[facing]);
    }

    //Gets and sets facing
    void GetDirection()
    {
        //get player input
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        //check if there is input
        if (horizontalMovement != 0f || verticalMovement != 0f)
        {
            //which way are we going

            if (horizontalMovement != 0) // Left or right travel
            {
                if (horizontalMovement > 0)
                {
                    facing = Direction.Right;
                }
                else
                {
                    facing = Direction.Left;
                }
            }
            if (verticalMovement != 0) // Up or down travel
            {
                if (verticalMovement > 0)
                {
                    facing = Direction.Up;
                }
                else
                {
                    facing = Direction.Down;
                }

            }

        }
    }
}
