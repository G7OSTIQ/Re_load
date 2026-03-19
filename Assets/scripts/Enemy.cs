using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(other.gameObject);
        }
        //destory bullet and kills enemy
        if (other.CompareTag("Players_bullet"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
    
}
