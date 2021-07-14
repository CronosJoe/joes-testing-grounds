using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurretScript : MonoBehaviour
{
    [SerializeField] int rotationSpeed;
    //this might change if I make an enemy manager idk yet
    public float playerScore; //the player is also doubling as the game manager because there isn't a lot of things the game manager needs to manage
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //probably could program this much better but I'm blanking in the speed
        RotationStartsHere(); //each frame I want to check the input, I'm including both a and d input so that if they press both at the same time it should "cancel" out
        if (Input.GetKey(KeyCode.Space)) 
        {
            ShootThemSpeedyPeople();
        }
    }

    void RotationStartsHere() //I'm thinking this should work by rotating on the z axis because in a 2d space 2d should be depth/direction pointing towards the camera
    {
        if (Input.GetKey(KeyCode.A)) //not using the GetAxis here might rework later
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime); //rotating clockwise
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Rotate(-Vector3.forward * rotationSpeed * Time.deltaTime); //counterclockwise probably
        }
    }
    void ShootThemSpeedyPeople() //this will be a 2d raycast
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up); //probably should shoot on the y?
        Debug.DrawRay(transform.position, Vector2.up, Color.red);
    }
}
