using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    // variable to store the player's rigid body
    private Rigidbody PlayerRigidBody; 

    // variable of unity input system. Creator needs to set up which keyboard press affects it.
    public InputAction JumpAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Fetching RigidBody Component from the GameObject this script is connected to. 
        PlayerRigidBody = GetComponent<Rigidbody>();

        //Every Input Action needs to be enabled for it to work
        JumpAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks if specific keyboard input is pressed/triggered.
        if(JumpAction.triggered)
        {
            PlayerRigidBody.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
