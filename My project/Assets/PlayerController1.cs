
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
<<<<<<< HEAD
{   


public float moveSpeed; 
public float jumpHeight; 
public KeyCode Spacebar;
public Transform groundCheck; 
public float groundCheckRadius; 
public LayerMask whatIsGround; 
private bool grounded; 

public KeyCode L;
public KeyCode R;
private Animator anim;
void start() {



}


void Update () {

if(Input.GetKeyDown(Spacebar))
{  
Jump(); 
}
if (Input.GetKey(L))
=======
>>>>>>> 90bd3c8a5571c839c7f78a1cb4dc9fba69134055
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
<<<<<<< HEAD
}


if (Input.GetKey(R))
{   

GetComponent<Rigidbody2D>().velocity=new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
if(GetComponent<SpriteRenderer>() != null)
{ 
GetComponent<SpriteRenderer>().flipX = true;
}
}
void Jump()
{
    GetComponent<Rigidbody2D>().velocity =new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
}

anim.SetFloat("Speed",Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));


if(GetComponent<SpriteRenderer>() != null)
{   
GetComponent<SpriteRenderer>().flipX = false;
}
}

}




=======
>>>>>>> 90bd3c8a5571c839c7f78a1cb4dc9fba69134055
