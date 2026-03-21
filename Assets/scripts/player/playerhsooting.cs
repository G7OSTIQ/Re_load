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
        
        //.wasPressedThisFrame   click to make event
        //.wasReleasedThisFrame  when click button lets go it will shoot not this sis not needed
        //.isPressed     when mouse is being hold down
    }
}
