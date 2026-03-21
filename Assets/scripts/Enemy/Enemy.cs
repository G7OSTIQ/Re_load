using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public int score = 10;
    public int powerup_score = 20;
    public static int player_total_score = 0; //Static here is needed for the score will be updated as there as a bug where it was only staying at 10
    public TMP_Text Player_score;
    
    
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
        }
        //destory bullet and kills enemy
        if (other.CompareTag("Players_bullet"))
        {
            player_total_score += score;
            Player_score.text = "Score: " + player_total_score;
            Destroy(other.gameObject);
            Destroy(gameObject);
           
        } 
        
    }
    
}
