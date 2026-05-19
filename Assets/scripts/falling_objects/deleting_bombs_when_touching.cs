using UnityEngine;

public class deleting_bombs_when_touching : MonoBehaviour
{

    public bool boms_touching_ground = false;
    public ParticleSystem fallingParticles;
    
    private void OnCollisionEnter(Collision collision)
    {
        
        if (fallingParticles != null)
        {
            ParticleSystem particles = Instantiate(
                fallingParticles,
                transform.position, 
                Quaternion.identity
            );
            particles.Play();
            Destroy(particles.gameObject, 2f); 
        }
        
        
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
            if (fallingParticles != null)
            {
                ParticleSystem particles = Instantiate(fallingParticles, transform.position, Quaternion.identity);
                particles.Play();
                Destroy(particles.gameObject, 2f);
            }
            
            Destroy(other.gameObject);
            Destroy(gameObject);
            Game_Over.gameover = true;
            GameObject.Find("Timer").SetActive(false); // set the timer hidden 
            
        }
    }
}
