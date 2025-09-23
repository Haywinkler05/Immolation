using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.PlayerActions movement;

    private PlayerMotor motor;
    private void Awake()
    {
        motor = GetComponent<PlayerMotor>();
        playerInput = new PlayerInput();
        movement = playerInput.Player;
    }
    private void FixedUpdate()
    {
       motor.processMove(movement.Movement.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movement.Enable();
    }
    private void OnDisable()
    {
        movement.Disable();
    }
}
