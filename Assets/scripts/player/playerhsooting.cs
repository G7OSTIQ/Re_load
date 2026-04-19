using UnityEngine;
using UnityEngine.InputSystem;

public class playerhsooting : MonoBehaviour
{


    public GameObject bulletpreflap;
    public Transform spawnpoint;
    public Animator myanimation;



    void Start()
    {
        myanimation = GetComponentInChildren<Animator>();
    }
    
    
    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            myanimation.SetTrigger("Shoot");
            Instantiate(bulletpreflap, spawnpoint.position, spawnpoint.rotation);
            
        }
        
        //.wasPressedThisFrame   click to make event
        //.wasReleasedThisFrame  when click button lets go it will shoot not this sis not needed
        //.isPressed     when mouse is being hold down
    }

    private void FixedUpdate()
    {
        
    }
}
