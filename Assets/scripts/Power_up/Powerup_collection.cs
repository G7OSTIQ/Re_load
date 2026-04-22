using UnityEngine;

public class Powerup_collection : MonoBehaviour
{
    public float time = 10f;
    public float powerspeed = 15f;
    public static bool powerupActive = false; // this needs to be static because it needs to share one piece of data

    private player_movement playermovement;

    void Start()
    {
        powerupActive = false;
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