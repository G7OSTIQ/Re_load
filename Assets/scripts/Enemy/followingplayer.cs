using UnityEngine;

public class followingplayer : MonoBehaviour
{
    
    //This what lets the enemy follow the player script
    
    public Transform player;
    public float smallspeed = 2f;
    public float highspeed = 8f;
    public int speedincrease = 1;
    public float timer_when_increase = 10f;
    public float currentspeed;
    private float timer = 0f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        currentspeed = Random.Range(smallspeed, highspeed);
        
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
        
        timer += Time.deltaTime;
        if (timer >= timer_when_increase)
        {
            currentspeed += speedincrease;
            timer = 0f;
        }
        
        Vector3 chese = Vector3.MoveTowards(transform.position, player.position, currentspeed * Time.deltaTime);
        transform.position = chese;
        
        Vector3 direction = player.position - transform.position;
        direction.y = 0;
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }

    }
}
