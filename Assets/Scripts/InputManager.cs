using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput; //This intializes our input map that is currently inside the inputs folder in assets
    private PlayerInput.PlayerActions playerActions; //This one specifically intializes the player actions inside the input map
   

    private PlayerMotor motor; //Make an instance of the player motor class
    private void Awake() //Awake happens at the start of unity
    {
        motor = GetComponent<PlayerMotor>(); //On awake it intializes the motor
        playerInput = new PlayerInput(); //Creates a new instance of the player input script that is generated automatically by unity
        playerActions = playerInput.Player; //Assins the new instance to the player map specifically in the input map

        playerActions.Jump.performed += ctx => motor.processJump(); //When the button is preformed, it points to the jump function
        playerActions.Sprint.performed += ctx => motor.processSprint();
        playerActions.Dash.performed += ctx => motor.processDash();
    }
    private void FixedUpdate() //Happens every couple of frames, normally used for physics and any movement
    {
       motor.processMove(playerActions.Movement.ReadValue<Vector2>()); //Reads the values from the movement and look map
        
       
    }
    private void LateUpdate()
    {
        motor.processLook(playerActions.Look.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        playerActions.Enable(); 
    }
    private void OnDisable()
    {
        playerActions.Disable(); 
    }
}
