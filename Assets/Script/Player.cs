using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Transform groundCheckCollider;

    // public 
    const float groundCheckRadius = 0.2f;
    public float speed = 5;
    //[SerializeField] bool isGrounded = false;

    
    float horizontalValue;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }
   
    void Update()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        Move(horizontalValue);
    }

    // void GroundCheck()
    // {
    //     //only layer ground
    //     isGrounded = false;
    //     Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
    //     if(colliders.Length > 0)
    //         isGrounded = true;

    // }

    void Move(float dir)
    {
        //GroundCheck();
        float xVal = dir * speed;
        Vector2 targetV = new Vector2(xVal, rb.velocity.y);
        rb.velocity = targetV;
    }
}
