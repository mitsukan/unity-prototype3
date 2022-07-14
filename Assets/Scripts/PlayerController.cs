using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Define a variable of rigidbody type
    private Rigidbody playerRigidBody;
    public float jumpForce = 10;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        // assign the rigidbody component to the variable
        playerRigidBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == true)
        {
            // The variable now has all of the methods for a rigibody, including add force
            // Adding a mode to the force, Impulse means that the force is applied immediately
            // instead of overtime. This means that the force applied can be less
            playerRigidBody.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
            isOnGround = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
