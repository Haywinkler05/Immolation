using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private CharacterController controller; //Calls the character controller
    [Header("Player movement settings")]
    [SerializeField] private float speed = 2f; //Player move speed
    
    [Header("Player Look settings")]
    [SerializeField]private float xRotation = 0;
    public float VerticalSense = 10f;
    public float HorizontalSense = 10f;
    [SerializeField] private Camera cam;
    void Start()
    {
        controller = GetComponent<CharacterController>(); //Assigns the character controller
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void processMove(Vector2 input) //Moves the player based on the input
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection * speed * Time.deltaTime));
    }


    public void processLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRotation -= mouseY * VerticalSense * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -80, 80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * HorizontalSense);
    }
  
}
