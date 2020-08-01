using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Base : MonoBehaviour
{

    
   Rigidbody2D rb;
   Vector2 MoveDir;

   BoxCollider2D bc;

  public float MoveSpeed=5f;

  public float JumpForce=10f;

  public LayerMask Ground;

    
   
    void Start()
    {
       rb=this.GetComponent<Rigidbody2D>();

       bc=this.GetComponent<BoxCollider2D>();

    }

  
    void Update()
    {
        MoveDir=new Vector2(Input.GetAxis("Horizontal"),0) ;

        if(Input.GetKeyDown(KeyCode.Space)&&IsGrounded())
        {
        rb.velocity=new Vector2(rb.velocity.x,JumpForce);
        }
    }

    void FixedUpdate()
    {
       rb.velocity=new Vector2(MoveDir.x*MoveSpeed*Time.fixedDeltaTime,rb.velocity.y);
    }

    bool IsGrounded()
    {
        RaycastHit2D rch = Physics2D.BoxCast(bc.bounds.center,bc.bounds.size,0f,Vector2.down,0.01f,Ground);

        return rch.collider!=null;
    }


}
