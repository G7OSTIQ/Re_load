using UnityEngine;

public class enemy_remover : MonoBehaviour
{
    public float timer = 20f;  
    public float maxtimer = 40f; 

    void Start()
    {
        float randomtimer = Random.Range(timer, maxtimer);
        Destroy(gameObject, randomtimer);
    }
}