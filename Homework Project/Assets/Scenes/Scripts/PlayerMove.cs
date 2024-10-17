using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //movement
    private float moveSpeed;
    public float dirX, dirZ;
    public float sprintSpeed;
    public float walkSpeed;
    public float currentSpeed;

    [SerializeField] private Movement movement;

    //other than movement
    public Rigidbody rb;

    //keybinds
    public KeyCode SprintKey = KeyCode.LeftShift;

    //other pt2
    private float movementState; public System.Single GetMovementState()
    {
        return movementState;
    }

    public void SetMovementState(System.Single value)
    {
        movementState = value;
    }

    public enum MovementState
    {
        walking,
        sprinting,
        air,
    }
private void Update()
{
    var targetAngle = Mathf.Atan2(dirX, dirZ) = Mathf.Rad2Deg;
    transform.rotation = Quaterion.Euler(0.0f, targetAngle, 0.0f);
}
public struct Movement
{
    public bool isSprinting;
}

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirZ = Input.GetAxis("Vertical") * moveSpeed;


        if (Input.GetKeyDown("Jump")) {
         rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }

        public void Sprint(InputAction.CallbackContext context)
        {
            movement.isSprinting = context.started || context.p
        }

        moveSpeed = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
        rb.AddForce (walkSpeed * currentSpeed);
    }
}
