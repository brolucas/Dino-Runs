using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGeneratorManager : MonoBehaviour
{
    [Header ("Required")]
    public Transform posSpawn;
    public Sprite[] groundObstacleSprite;
    public GameObject groundObstacle;

    [Header ("Spawning Option")]
    public float timeBetween;
    public float speed;
    private float defaultTime;


    void Start()
    {
        defaultTime = timeBetween;
    }


    void Update()
    {
        timeBetween -= Time.deltaTime;

        if (timeBetween < 0)
        {
            timeBetween = defaultTime;
            SpawnObstacle();
        }
    }


    private void SpawnObstacle()
    {
        GameObject instObstacle = Instantiate(groundObstacle, posSpawn);
        instObstacle.GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed);

        int spritIndex = Random.Range(0, groundObstacleSprite.Length);
        instObstacle.GetComponent<SpriteRenderer>().sprite = groundObstacleSprite[spritIndex];

        instObstacle.tag = "Obstacle";
    }
}
