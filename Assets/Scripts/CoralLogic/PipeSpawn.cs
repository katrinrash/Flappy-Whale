using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject[] pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    int randomIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe(randomIndex = Random.Range(0, pipe.Length));
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            randomIndex = Random.Range(0, pipe.Length);
            spawnPipe(randomIndex);
            timer = 0;
        }

    }

    void spawnPipe(int index)
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe[index], new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
