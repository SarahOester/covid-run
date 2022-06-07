using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
            if (startTimeBtwSpawns > minTime) {
                startTimeBtwSpawns -= decreaseTime;
            }
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}