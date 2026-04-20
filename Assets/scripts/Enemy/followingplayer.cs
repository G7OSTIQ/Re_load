using UnityEngine;

public class followingplayer : MonoBehaviour
{
    
    //This what lets the enemy follow the player script
    
    public Transform player;
    public float speed = 5f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        GameObject findingplayer = GameObject.FindWithTag("Player");
        if (findingplayer != null)
        {
            player = findingplayer.transform;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        
        Vector3 chese = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        transform.position = chese;
        
        Vector3 direction = player.position - transform.position;
        direction.y = 0;
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

    }
}
