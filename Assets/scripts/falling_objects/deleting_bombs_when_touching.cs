using UnityEngine;

public class deleting_bombs_when_touching : MonoBehaviour
{

    public bool boms_touching_ground = false;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            boms_touching_ground = true;
            Destroy(gameObject);
        }
        
        
        Destroy(gameObject); // need this so that it will delete it self if touching something else
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Game_Over.gameover = true;
            GameObject.Find("Timer").SetActive(false); // set the timer and score hidden 
            GameObject.Find("Score").SetActive(false);
        }
    }
}
