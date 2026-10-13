using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
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
{
    GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

if(GetComponent<SpriteRenderer>() != null)
{
GetComponent<SpriteRenderer>().flipX = true;
}
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




