using UnityEngine;

public class Powerup_particles : MonoBehaviour
{
    public ParticleSystem dashparticles;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (dashparticles != null)
        {
            dashparticles.Play();
        }
    }
}
