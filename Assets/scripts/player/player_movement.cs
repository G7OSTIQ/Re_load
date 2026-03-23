using UnityEngine;
using UnityEngine.InputSystem;

public class player_movement : MonoBehaviour
{
    public float speed = 10f;
    public float jumpingspeed = 5f;
    public Rigidbody player1;
    private Vector3 movement;
    //private bool playerTouchGround = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player1.freezeRotation = true; // this stops it from tripping down when rotating can can also do it from inprector in Rigidbody in constraints Freeze Rotation
        player1.linearVelocity = Vector3.zero;
        Time.timeScale = 1f;             
    }

    // Update is called once per frame
    void Update()
    {
        
        movement = Vector3.zero;
        //if (Keyboard.current.spaceKey.isPressed && playerTouchGround)
       // {
         //   player1.linearVelocity = new Vector3(player1.linearVelocity.x, jumpingspeed);
         //   playerTouchGround = false;
       // }
       if (Keyboard.current.dKey.isPressed)
       {
           movement.x =  1;
           transform.rotation = Quaternion.Euler(0,  90, 0);
       }

       if (Keyboard.current.aKey.isPressed)
       {
           movement.x = -1;
           transform.rotation = Quaternion.Euler(0, -90, 0);
       }

       if (Keyboard.current.wKey.isPressed)
       {
           movement.z =  1;
           transform.rotation = Quaternion.Euler(0,   0, 0);
       }

       if (Keyboard.current.sKey.isPressed)
       {
           movement.z = -1;
           transform.rotation = Quaternion.Euler(0, 180, 0);
       }
       
       if (Keyboard.current.wKey.isPressed && Keyboard.current.dKey.isPressed)
       {
           transform.rotation = Quaternion.Euler(0, 45, 0); 
       }
       if (Keyboard.current.wKey.isPressed && Keyboard.current.aKey.isPressed)
       {
           transform.rotation = Quaternion.Euler(0, -45, 0);
       }
       if (Keyboard.current.sKey.isPressed && Keyboard.current.dKey.isPressed)
       {
           transform.rotation = Quaternion.Euler(0, 135, 0);
       }
       if (Keyboard.current.sKey.isPressed && Keyboard.current.aKey.isPressed)
       {
           transform.rotation = Quaternion.Euler(0, -135, 0);
       }
        
        
        
    }
    
    private void FixedUpdate()
    {
        player1.linearVelocity = new Vector3(
            movement.x * speed, player1.linearVelocity.y, movement.z * speed
        );
    }

    //private void OnCollisionEnter(Collision collision)
   // {
     //   if (collision.gameObject.CompareTag("ground"))
     //   {
    //        playerTouchGround = true;
    //    }
   // }
}
