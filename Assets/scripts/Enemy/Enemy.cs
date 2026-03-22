using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public int score = 10;
    public int powerup_score = 20;
    public static int player_total_score = 0; //Static here is needed for the score will be updated as there as a bug where it was only staying at 10
    public TMP_Text Player_score;
    private bool alreadyhit = false; // This is needed coz the enemy has to colliders where if it get's hit by a bullet it adds the score twice 
    
    
    void Start()
    {
        Player_score = GameObject.Find("Score").GetComponent<TMP_Text>(); 
        // This will find the Text score because since enemy is in prefabs it won't let me drag it into the text box. This way this code will find it and drag into it right away
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Game_Over.gameover = true; //once player is dead the gameover screen will show.
            GameObject.Find("Timer").SetActive(false); // set the timer and score hidden 
            GameObject.Find("Score").SetActive(false);
        }
        
        //destory bullet and kills enemy and scores
        if (other.CompareTag("Players_bullet"))
        {
            
            if (alreadyhit) return; // this now check if it was hit once else it will ignore the sec hit and gives only 1 score point not two
            alreadyhit = true;
            
            if (Powerup_collection.powerupActive)
            {
                player_total_score += powerup_score;
            }
            else
            {
                player_total_score += score;
            }
            
            Player_score.text = "Score: " + player_total_score;
            
            if (!Powerup_collection.powerupActive)// If powerup is collected the bullet will stay
            {
                Destroy(other.gameObject);
            }

            Destroy(gameObject); // else it will  get destroyed
        }
        
    }
    
}
