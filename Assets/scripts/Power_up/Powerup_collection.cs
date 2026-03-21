using UnityEngine;

public class bullet_collection : MonoBehaviour
{
    public int reload = 0;
    public float time = 10f;
    public float powerspeed = 25f;
    public bool powerupActive = false;

    private player_movement playermovement;

    void Start()
    {
        playermovement = GetComponent<player_movement>(); // This gets a script where it needs to overwrite later on
    }

    void Update()
    {
        if (powerupActive)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                powerupActive = false;
                playermovement.speed = 10f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            powerupActive = true;
            time = 10f; //This starts timer once player touches the powerup
            playermovement.speed = powerspeed;     
            Destroy(other.gameObject);
        }
    }
}