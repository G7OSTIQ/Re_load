using UnityEngine;

public class falling_shadow : MonoBehaviour
{
    public GameObject shadowprefab;
    public float groundY = 0f;     

    private GameObject shadow;

    void Start()
    {
        Vector3 shadowpos = new Vector3(transform.position.x, groundY + 0.01f, transform.position.z);
        shadow = Instantiate(shadowprefab, shadowpos, Quaternion.identity);
    }

    void Update()
    {
        if (shadow != null)
        {
            shadow.transform.position = new Vector3(transform.position.x, groundY + 0.01f, transform.position.z);
            
            float height = transform.position.y - groundY;
            float scalesize = Mathf.Clamp(3f - (height / 10f), 0.5f, 3f);
            shadow.transform.localScale = new Vector3(scalesize, 0.1f, scalesize);
        }
    }

    void OnDestroy()
    {
        if (shadow != null)
        {
            Destroy(shadow);
        }
    }
}