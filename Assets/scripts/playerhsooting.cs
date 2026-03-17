using UnityEngine;
using UnityEngine.InputSystem;

public class playerhsooting : MonoBehaviour
{


    public GameObject bulletpreflap;
    
    public Transform spawnpoint;

    // Update is called once per frame
    void Update()
    {

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            
            Instantiate(bulletpreflap, spawnpoint.position, spawnpoint.rotation);
            
        }
        
        //.wasPressedThisFrame   triggered once on click
        //.wasReleasedThisFrame  triggered once on release
        //.isPressed     when mouse is being hold down
        
        
    }
}
