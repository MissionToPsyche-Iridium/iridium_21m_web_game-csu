using UnityEngine;

public class asteroidSpanner : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnRate = 5;
    public float timer = 0;
    public float heightOffset = 10 ;

    public float HeightOffset {get => heightOffset; set => heightOffset = value; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRocks();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnRocks();
            timer = 0;
        }

    }
    private void spawnRocks()
    {
        float lowestPoint = transform.position.y - HeightOffset;
        float highestPoint = transform.position.y + HeightOffset;

        Instantiate(asteroid, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }

    
}
