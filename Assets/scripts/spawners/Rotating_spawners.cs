using UnityEngine;

public class Rotating_spawners : MonoBehaviour
{
    public float rotationwheel = 180f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotationwheel * Time.deltaTime);
        
        
        //forawrd is blue, up is green, right is red
    }
}
