using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{   


public float moveSpeed; 
public float jumpHeight; 
public KeyCode Spacebar;

public KeyCode L;
public KeyCode R;
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
}
void Jump()
{
    GetComponent<Rigidbody2D>().velocity =new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
}




if(GetComponent<SpriteRenderer>() != null)
{   
GetComponent<SpriteRenderer>().flipX = false;
}
}


}




