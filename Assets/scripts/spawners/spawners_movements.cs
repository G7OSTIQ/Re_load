using UnityEngine;

public class spawners_movements : MonoBehaviour
{
    //This is used to set the movement left and right or up and down for all the spawners
    public float speed = 5f;
    public float distance = 50f;
    private Vector3 zeroposition;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zeroposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moving = Mathf.PingPong(Time.time * speed, distance); //mathf.pingpong will create a back and forth motion depended on which x-ais and distance
        if(gameObject.CompareTag("above_object1"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        else if(gameObject.CompareTag("above_objects_4"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        else if (gameObject.CompareTag("above_object2"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zeroposition.z + moving);
        }
        else if (gameObject.CompareTag("above_objects3"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zeroposition.z + moving);
        }
        else if (gameObject.CompareTag("Small_enimie"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        else if (gameObject.CompareTag("Power_up_spawner"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        else if (gameObject.CompareTag("enemy_spawner4"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zeroposition.z + moving);
        }
        else if (gameObject.CompareTag("enemy_spawner2"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zeroposition.z + moving);
        }
        else if (gameObject.CompareTag("enemy_spawner1"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        else if (gameObject.CompareTag("enemy_spawner3"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        else if (gameObject.CompareTag("Power_up_spawner_3"))
        {
            transform.position = new Vector3(zeroposition.x + moving, transform.position.y, transform.position.z);
        }
        // else if (gameObject.CompareTag("Power_up_spawner_2"))
        //{
        //   transform.position = new Vector3(transform.position.x, transform.position.y, zeroposition.z  + moving);
        //}
        
        
    }
}
