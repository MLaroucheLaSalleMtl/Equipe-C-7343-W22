using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerControls playerControls;

   // Vector3 movement = Vector3.zero;
    [SerializeField] public float forwardSpeed = 1f;
    [SerializeField] Rigidbody rb;
    [SerializeField] GroundCheck groundCheck;
    private float speed = 12f;
    Vector2 velocity;
    public float maxGroundDistance = .3f;
    public bool isGrounded;
    [SerializeField] private float jumpForce = 5f;


    public void Awake()
    {
        playerInput = GetComponent<PlayerInput>();

        playerControls = new PlayerControls();

    }
    void Reset()
    {
        groundCheck = GetComponentInChildren<GroundCheck>();
        if (!groundCheck)
        {
            groundCheck = GroundCheck.Create(transform);
        }
    }
    private void OnEnable()
    {
        playerControls.MyControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.MyControls.Disable();
    }
    public void Jumped(InputAction.CallbackContext context)
    {
         if (context.performed && groundCheck.isGrounded)
         {
             rb.AddForce(Vector3.up * 100 * jumpForce);
         }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void LateUpdate()
    {

    }
    private void FixedUpdate()
    {
        velocity.x = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector3(velocity.x , rb.velocity.y, forwardSpeed * speed);
    }
}
