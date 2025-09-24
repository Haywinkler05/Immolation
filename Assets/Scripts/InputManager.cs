using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerActions playerActions;
   

    private PlayerMotor motor;
    private void Awake()
    {
        motor = GetComponent<PlayerMotor>();
        playerInput = new PlayerInput();
        playerActions = playerInput.Player;
    }
    private void FixedUpdate()
    {
       motor.processMove(playerActions.Movement.ReadValue<Vector2>());
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
