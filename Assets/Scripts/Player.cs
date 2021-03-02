using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public or private ref
    // data type (int, float, bool, string)
    [SerializeField]
    private int _movementSpeed = 3; 

    // Start is called before the first frame update
    void Start()
    {
        // take current position = new position (0,0,0)
        transform.position = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        // read user input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Move based on position
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);
        transform.Translate(direction * _movementSpeed * Time.deltaTime);
        
        // Get player position
        float playerX = transform.position.x;
        float playerY = transform.position.y;

        // Check if player out of bounds
        if (playerX >= 9.25 || playerX <= -9.25) 
        {
            // move player
            if (playerX >= 9.25)
            {
                transform.position = new Vector3(9.25f, playerY, 0);

            } else
            {
                transform.position = new Vector3(-9.25f, playerY, 0);
            }
            playerX = transform.position.x;
        }
        if (playerY >= 6 || playerY <= -4)
        {
            if (playerY >= 6)
            {
                transform.position = new Vector3(playerX, 6, 0);
            } else 
            {
                transform.position = new Vector3(playerX, -4, 0);
            }
        }
    }
}
