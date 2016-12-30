using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private float movementSpeed = 12.0f;
    private float mouseSensitivity = 5.0f;
    private float JumpSpeed = 0.5f;
    private float walkSpeed = 6.0f;

    

    float verticalRotation = 0;
    public float upDownRange = 20.0f;
    bool b = false;

    // Use this for initialization
    void Start () 
    {
        
       // Cursor.lockState = CursorLockMode.Locked; //Hiding cursor
    }

    // Is called once per frame
    void OnCollisionStay()
    {
        b = false;
    }

    void Update () 
    {
        //rotation
        float rotLeftRight = Input.GetAxis("Mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);

        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation = Mathf.Clamp(verticalRotation, -upDownRange, upDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);


        /*  float rotUpDown = Input.GetAxis("Mouse Y") * mouseSensitivity
           Camera.main.transform.Rotate(-rotUpDown, 0, 0); */

        //movement
        if (b == false && (Input.GetKey("space")))
        {
            
            transform.Translate(Vector3.up * JumpSpeed);
            
        }
        b = true;

        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);

        speed = transform.rotation * speed;

        CharacterController cc = GetComponent<CharacterController>();

        cc.SimpleMove( speed );
       // cc.detectCollisions = false;

        //shifting
        if(Input.GetKeyDown("left shift"))
        {
            movementSpeed = walkSpeed; //(movementSpeed * shiftSpeed);

        }
        if(Input.GetKeyUp("left shift"))
        {
            movementSpeed = 12.0f;
        } 

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.None;
        }
        if(Input.GetKey(KeyCode.C))
        {
            Camera.main.transform.position = new Vector3(transform.position.x, (transform.position.y)+2, (transform.position.z * 1.12f)-2);
        }
    }
}