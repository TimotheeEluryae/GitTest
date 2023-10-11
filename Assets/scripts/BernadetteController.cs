using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UIElements;

public class BernadetteController : MonoBehaviour
{
   
    Rigidbody2D rb;
    public float jumpforce;
    public float movespeed;
    public float smoothspeed;
    private float vector2reference;
    public float jumplr;
    Vector2 reference;

    private void Start()
    {
   
       rb = GetComponent<Rigidbody2D>();
          
    }

    bool touchingWall;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        touchingWall = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        touchingWall = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(rb.velocity.y) <= 0.1f)
        {
            rb.AddForce(new Vector2(0, jumpforce));

        }

        Vector2 newVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && touchingWall ) 
        {

            newVelocity.x = -movespeed;
            newVelocity.y = jumplr;

        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && touchingWall)
        {

            newVelocity.x = movespeed;
            newVelocity.y = jumplr;
        }

        rb.velocity = newVelocity;
        //rb.velocity = Vector2.SmoothDamp(rb.velocity, newVelocity, ref reference, smoothspeed);
    }
}
