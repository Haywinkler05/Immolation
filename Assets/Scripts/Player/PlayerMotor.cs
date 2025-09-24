using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
   

    private CharacterController controller; //Calls the character controller
    [Header("Player movement settings")]
    [SerializeField] private float speed = 2f; //Player move speed
    
    [Header("Player Look settings")]
    [SerializeField]private float xRotation = 0;
    public float VerticalSense = 10f;
    public float HorizontalSense = 10f;
    [SerializeField] private Camera cam;
    void Start() // Start is called once before the first execution of Update after the MonoBehaviour is created
    {
        controller = GetComponent<CharacterController>(); //Assigns the character controller
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void processMove(Vector2 input) //Moves the player based on the input
    {
        Vector3 moveDirection = Vector3.zero; //assigns the move direction to a vector of <0,0,0>
        moveDirection.x = input.x;
        moveDirection.z = input.y;//Gets the input vectors assigned by the parameter
        controller.Move(transform.TransformDirection(moveDirection * speed * Time.deltaTime));
        //Tells the character controller to move by transforming the player position with the speed and adjusted for frames
    }


    public void processLook(Vector2 input)
    {
        float mouseX = input.x; //Gets the mouse x and y location
        float mouseY = input.y;
        
        //The code below is for the vertical movement and will rotate around the X-axis (up and down)
        xRotation -= mouseY * VerticalSense * Time.deltaTime; //Subtracts the roation of the x by the mouse y position multiplied by the y sense
        xRotation = Mathf.Clamp(xRotation, -80, 80f); //This restricts the x rotation between -80 and 80
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0); //Converts the vectors into angles and will rotate the camera accordingly

        //The code below is for  the x axis and will physically turn the player when the mouse looks left or right
            //Why we use transform.rotate here and not cam.transform like above
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * HorizontalSense); //Allows the player to look right and left
    }
  
}
