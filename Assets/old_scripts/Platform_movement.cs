using UnityEngine;

public class Platform_movement : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 3;
    public float speed = 2f;
    public float spacing = 3f;

    public GameObject[] platforms;
    private Vector3[] positions;
    private float time = 0f;

    void Start()
    {
        platforms = new GameObject[platformCount];
        positions = new Vector3[platformCount];

        for (int i = 0; i < platformCount; i++)
        {
            Vector3 spawnPos = new Vector3(
                transform.position.x + (i * spacing),
                transform.position.y,
                transform.position.z
            );
            platforms[i] = Instantiate(platformPrefab, spawnPos, Quaternion.identity);
            positions[i] = spawnPos;
        }
    }

    void Update()
    {
        time += Time.deltaTime * speed;

        // head moves in a circle (top-down = X and Z)
        positions[0] = new Vector3(
            transform.position.x + Mathf.Sin(time) * 6f,
            transform.position.y,
            transform.position.z + Mathf.Cos(time) * 6f
        );

        // each platform smoothly follows the one ahead
        for (int i = 1; i < platformCount; i++)
        {
            positions[i] = Vector3.MoveTowards(
                positions[i],
                positions[i - 1],
                speed * Time.deltaTime * 3f
            );
        }

        for (int i = 0; i < platformCount; i++)
        {
            platforms[i].transform.position = positions[i];
        }
    }
}