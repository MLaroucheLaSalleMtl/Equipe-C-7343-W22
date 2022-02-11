using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction playerControls;

    Vector3 movement = Vector3.zero;
   [SerializeField] public float forwardSpeed = 1f;
   [SerializeField] Rigidbody rb;
    private float speed = 12f;


    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        movement = playerControls.ReadValue<Vector3>();
        

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(movement.x * speed, movement.y, forwardSpeed * speed);
    }
}
