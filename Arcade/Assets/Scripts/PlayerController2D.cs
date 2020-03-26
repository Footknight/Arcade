using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour {

  
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;

    private bool isGrounded;
    [SerializeField]
    Transform groundCheck;

    [SerializeField]
    private float runspeed;
    [SerializeField]
    private float jumpspeed;

   


	// Use this for initialization
	void Start () {

        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
		
	}
	

    // Mapping the keyboard

    private void FixedUpdate()
    {

        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGrounded = true;
            Debug.Log("isGrounded is currently true");
        }
        else
        {
            isGrounded = false;
            Debug.Log("isGrounded is currently false");
        }

        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(runspeed, rb2d.velocity.y);
            if (isGrounded)


            spriteRenderer.flipX = false;
        }
        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-runspeed, rb2d.velocity.y);
            if (isGrounded)

            spriteRenderer.flipX = true;

        }
        else
        {
            if (isGrounded)
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            spriteRenderer.flipX = false;

        }
        // Jump Settings
        if(Input.GetKey("space") && isGrounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpspeed);

            


      
        }
        
    }


}
