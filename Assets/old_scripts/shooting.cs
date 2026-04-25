using UnityEngine;

public class shooting : MonoBehaviour
{

    public float bulletspeed = 50f;
    public Rigidbody bullet;
    private Animator myanimation;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        bullet.AddForce(transform.forward * bulletspeed, ForceMode.Impulse);
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
