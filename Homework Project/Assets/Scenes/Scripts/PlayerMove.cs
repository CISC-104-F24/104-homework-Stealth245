using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    public float dirX, dirZ;

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


        if(Input.GetButtonDown("Jump")) {
         rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
