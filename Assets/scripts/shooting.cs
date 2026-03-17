using UnityEngine;

public class shooting : MonoBehaviour
{

    public float bulletspeed = 50f;
    public Rigidbody myplayerbody;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        myplayerbody.AddForce(transform.forward * bulletspeed, ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
