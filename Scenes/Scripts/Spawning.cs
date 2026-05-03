
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject obstacle;
    public float minX, minY,  maxY;
    public float maxX;
    public float timebetweenspawn;
    private  float spawntime;


    // Update is called once per frame
    void Update()
    { if (Time.time > spawntime)
        {
            Spawn();
            spawntime = Time.time + timebetweenspawn;
        }

    }
    void Spawn()
    {
        float randomnX = Random.Range(minX, maxX);
        float randomnY = Random.Range(minY, maxY);
        Instantiate(obstacle, transform.position + new Vector3(randomnX, randomnY, 0), transform.rotation);
    }
}
