using UnityEngine;

public class Walk: MonoBehaviour
{
    [Header("Player Settings")]
    public float speed = 5f;
    public float jumpForce = 6.5f;

    [Header("References")]
    public Rigidbody rb;
    public Joystick moveJoystick;

    [Header("Ground Settings")]
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float groundDistance = 0.3f;

    private bool isGrounded = false;

    void Update()
    {
        CheckGround();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        Vector3 move = transform.right * moveJoystick.Horizontal + transform.forward * moveJoystick.Vertical;
        Vector3 velocity = move * speed;
        velocity.y = rb.velocity.y;
        rb.velocity = velocity;
    }


    void CheckGround()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer);
    }
}
