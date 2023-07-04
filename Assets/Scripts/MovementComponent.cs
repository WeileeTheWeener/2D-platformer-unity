using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float jumpCount;
    [SerializeField] private float currentJumpCount;

    public UnityEvent onCollided;


    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private Vector2 GetHorizontalInput()
    {
        float horizontalAxis = Input.GetAxisRaw("Horizontal");
        Vector2 input = new Vector2(horizontalAxis,0);
        return input;
    }
    private void Move()
    {
        rb.AddForce(GetHorizontalInput() * speed,ForceMode2D.Force);
    }
    private void Jump()
    {
        if(Input.GetButtonDown("Vertical") && currentJumpCount>0) 
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            currentJumpCount--;
            currentJumpCount = Mathf.Clamp(currentJumpCount, 0, jumpCount);
        }
    
    }
    private void LimitMovementSpeed()
    {
        if(rb.velocity.magnitude >= maxSpeed)
        {
            Vector3 clampedHorizontalSpeed = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
            rb.velocity = new Vector3(clampedHorizontalSpeed.x,rb.velocity.y);
        }
    }
    public void ResetJumpCount()
    {
        currentJumpCount = jumpCount;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        LimitMovementSpeed();
    }
}
