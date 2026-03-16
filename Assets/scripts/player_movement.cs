using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpingspeed = 5f;
    public Rigidbody player1;
    private Vector3 movement;
    private bool playerTouchGround = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        movement = Vector3.zero;
        if (Keyboard.current.wKey.isPressed && playerTouchGround)
        {
            player1.linearVelocity = new Vector3(player1.linearVelocity.x, jumpingspeed);
            playerTouchGround = false;
        }else if (Keyboard.current.dKey.isPressed)
        {
            movement.x = 1;
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            movement.x = -1;
        }
        movement.Normalize();
        
        
        
    }
    
    private void FixedUpdate()
    {
        player1.linearVelocity = new Vector3(
            movement.x * speed, player1.linearVelocity.y, movement.z * speed
        );
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            playerTouchGround = true;
        }
    }
}
