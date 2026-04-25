using UnityEngine;

public class platforms_movement : MonoBehaviour
{
    //This is used to set the movement left and right or up and down for all the spawners
    public float speed = 3f;
    private Vector3 direction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // set direction based on tag
        if (gameObject.CompareTag("left_whole_platforms"))
        {
            direction = Vector3.right; // moves along X axis
        }
        else if (gameObject.CompareTag("above_whole_platforms"))
        {
            direction = Vector3.forward; // moves along Z axis
        }
    }

    void Update()
    {
        // keep moving forever in one direction
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}
