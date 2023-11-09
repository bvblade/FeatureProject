using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public InputManager inputManager;

    public Rigidbody rb;

    public float speed = 10;

    public float runSpeed = 15;
    public float jumpForce = 200;

    private bool _isGrounded;

    private void Start()
    {
        inputManager.inputMaster.Movement.Jump.started += _ => Jump();
    }

    private void Update()
    {
        float forward = inputManager.inputMaster.Movement.Forward.ReadValue<float>();
        float right = inputManager.inputMaster.Movement.Right.ReadValue<float>();
        Vector3 move = transform.right * right + transform.forward * forward;

        move *= inputManager.inputMaster.Movement.Run.ReadValue<float>() == 0 ? speed : runSpeed;
        transform.localScale = new Vector3(x: 1, y: inputManager.inputMaster.Movement.Crouch.ReadValue<float>() == 0 ? 1f : 0.72618f, z: 1);

        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            _isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.transform.CompareTag("Ground"))
        {
            _isGrounded = false;
        }
    }

    void Jump()
    {
        if (_isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
}
