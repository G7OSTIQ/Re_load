using UnityEngine;

public class Players_bullet_deleting : MonoBehaviour
{

    public float timer = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer);
    }
    
}
