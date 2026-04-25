using UnityEngine;

public class Platform_Group_Spawner : MonoBehaviour
{
    public GameObject platforms;
    public Transform[] platformspawner;
    public float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnGroup", 2f, spawnInterval);
    }

    private void SpawnGroup()
    {
        int random = Random.Range(0, 3);

        if (random == 0)
        {
            foreach (Transform point in platformspawner)
            {
                SpawnAt(point);
            }
        }
        else if (random == 1)
        {
            int count = Random.Range(1, platformspawner.Length);
            for (int i = 0; i < count; i++)
            {
                int randomPoint = Random.Range(0, platformspawner.Length);
                SpawnAt(platformspawner[randomPoint]);
            }
        }
        else
        {
            int randomPoint = Random.Range(0, platformspawner.Length);
            SpawnAt(platformspawner[randomPoint]);
        }
    }

    private void SpawnAt(Transform point)
    {
        // ✅ check if a platform already exists at this spawn point
        Collider[] existing = Physics.OverlapSphere(point.position, 1f);
        foreach (Collider col in existing)
        {
            if (col.CompareTag("left_whole_platforms"))
            {
                return; // ✅ already a platform here, skip spawning
            }
        }

        Instantiate(platforms, point.position, point.rotation);
    }
}