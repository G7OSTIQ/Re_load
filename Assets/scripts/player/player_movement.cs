using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class player_movement : MonoBehaviour
{
    public float speed = 10.5f;
    public Rigidbody player1;
    
    [Header("Dash_Settings")]
    public float dashspeed = 30f;     
    public float dashduration = 0.2f;  
    public float dashrecharge = 3f;   
    public int maxdashes = 3;   
    
    
    [Header("Dash_UI")]
    public Image dashbar;    
    public Image dashbarcolor;      

    private Vector3 movement;
    public int currentdashes;        
    private bool isdashing = false;
    private float rechargetimer = 0f;
    
    
    private Animator myanimation;
    //private bool playerTouchGround = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentdashes = maxdashes;
        myanimation = GetComponent<Animator>();
        player1.freezeRotation = true; // this stops it from tripping down when rotating can can also do it from inprector in Rigidbody in constraints Freeze Rotation
        player1.linearVelocity = Vector3.zero;
        Time.timeScale = 1f;     
        UpdateDashUI();
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
       
       if (Keyboard.current.spaceKey.wasPressedThisFrame && currentdashes > 0 && !isdashing)
       {
           StartCoroutine(Dash());
       }

       if ((Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame) &&
           currentdashes > 0 && !isdashing)
       {
           StartCoroutine(Dash());
       }
       
       if (currentdashes < maxdashes)
       {
           rechargetimer += Time.deltaTime;
           if (rechargetimer >= dashrecharge)
           {
               currentdashes++;         
               rechargetimer = 0f;     
           }
       }
       
       movement.Normalize();
       UpdateDashUI();
        
    }
    
    void UpdateDashUI()
    {
        float fillamount = (currentdashes + (rechargetimer / dashrecharge)) / maxdashes;
        dashbar.fillAmount = fillamount;
        
        if (currentdashes == 0)
        {
            dashbar.color = Color.red;     
        }
        else if (currentdashes == 1)
        {
            dashbar.color = Color.yellow; 
        }
        else
        {
            dashbar.color = Color.green;  
        }
    }
    
    private System.Collections.IEnumerator Dash()
    {
        isdashing = true;
        currentdashes--;

        Vector3 dashdir = movement != Vector3.zero ? movement : transform.forward;
        player1.linearVelocity = dashdir * dashspeed;

        yield return new WaitForSeconds(dashduration);
        isdashing = false;
    }
    
    private void FixedUpdate()
    {
        if (!isdashing)
        {
            player1.linearVelocity = new Vector3(
                movement.x * speed, player1.linearVelocity.y, movement.z * speed
            );
        }
        
        float velocityX = Mathf.Abs(player1.linearVelocity.x);
        float velocityZ = Mathf.Abs(player1.linearVelocity.z);
        float totalvelocity = velocityX + velocityZ;
        
        myanimation.SetFloat("movement", totalvelocity);
    }

    //private void OnCollisionEnter(Collision collision)
   // {
     //   if (collision.gameObject.CompareTag("ground"))
     //   {
    //        playerTouchGround = true;
    //    }
   // }
}
