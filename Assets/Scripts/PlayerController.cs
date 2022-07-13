using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Define a variable of rigidbody type
    private Rigidbody playerRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // assign the rigidbody component to the variable
        playerRigidBody = GetComponent<Rigidbody>();
        // The variable now has all of the methods for a rigibody, including add force
        playerRigidBody.AddForce(Vector3.up * 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
