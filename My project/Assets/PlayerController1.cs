
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 8f;

    public KeyCode Spacebar = KeyCode.Space;
    public KeyCode L = KeyCode.A;
    public KeyCode R = KeyCode.D;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private bool isGrounded;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(Spacebar) && isGrounded)
        {
            Jump();
        }

        if (Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                -moveSpeed,
                GetComponent<Rigidbody2D>().velocity.y
            );

            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                moveSpeed,
                GetComponent<Rigidbody2D>().velocity.y
            );

            GetComponent<SpriteRenderer>().flipX = false;
        }

        GetComponent<Animator>().SetFloat(
            "Speed",
            Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x)
        );

        GetComponent<Animator>().SetFloat(
            "Height",
            GetComponent<Rigidbody2D>().velocity.y
        );

        GetComponent<Animator>().SetBool("Grounded", isGrounded);
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(
            GetComponent<Rigidbody2D>().velocity.x,
            jumpHeight
        );
    }

    void FixedUpdate()
    {
        if (groundCheck != null)
        {
            isGrounded = Physics2D.OverlapCircle(
                groundCheck.position,
                groundCheckRadius,
                groundLayer
            );
        }
    }
}
