using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 10f; // speed of the car
    public float jumpForce = 5f; // force of the car's jump

    private Rigidbody rb; // rigidbody of the car

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // get the car's rigidbody
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // get horizontal input (A and D keys)
        float moveVertical = Input.GetAxis("Vertical"); // get vertical input (W and S keys)

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // create a movement vector based on input
        rb.AddForce(movement * speed); // add force to the car based on the movement vector

        if (Input.GetKeyDown(KeyCode.Space)) // if the space bar is pressed
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // add upward force to the car to make it jump
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Cursor.lockState = CursorLockMode.None; // unlock the cursor when the game window is focused
            Cursor.visible = true; // show the cursor
        }
    }
}
