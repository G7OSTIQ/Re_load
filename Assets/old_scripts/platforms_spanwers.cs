using UnityEngine;
using System.Collections.Generic;

public class platforms_spanwers : MonoBehaviour
{
    public GameObject platforms;
    public Transform[] platformspawner;

    private List<GameObject> spawnedPlatforms = new List<GameObject>(); // ✅ track all spawned platforms

    void Start()
    {
        if (gameObject.CompareTag("left_whole_platforms"))
        {
            InvokeRepeating("Spawnobjects", 5f, 1f);
        }
    }

    private void Spawnobjects()
    {
        int inside_list = Random.Range(0, platformspawner.Length);
        Transform spawnPoint = platformspawner[inside_list];

        GameObject newPlatform = Instantiate(platforms, spawnPoint.position, spawnPoint.rotation);
        newPlatform.transform.SetParent(this.transform, true); // ✅ parent to THIS object
        spawnedPlatforms.Add(newPlatform);
    }
}