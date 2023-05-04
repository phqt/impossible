using UnityEngine;
using System.Collections;
using System;
using System.Numerics;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;
using Quaternion = UnityEngine.Quaternion;

public class BirdSpawner : MonoBehaviour
{

    public GameObject[] birdPrefabs; // an array of 5 bird prefabs
    public float spawnInterval = 5f; // time interval between bird spawns
    public float birdSpeed = 3f; // speed of bird movement
    public float minBirdY = 0.5f; // minimum Y position of bird spawn
    public float maxBirdY = 3.5f; // maximum Y position of bird spawn

    private float spawnTime; // time when the next bird should be spawned

    void Start()
    {
        spawnTime = Time.time + spawnInterval; // initialize the spawn time
    }

    void Update()
    {
        // spawn a random number of birds if it's time to do so
        if (Time.time >= spawnTime)
        {
            int numBirds = Random.Range(1, 6); // select a random number of birds between 1 and 5
            for (int i = 0; i < numBirds; i++)
            {
                SpawnBird();
            }
            spawnTime = Time.time + spawnInterval; // update the spawn time
        }
    }

    void SpawnBird()
    {
        // select a random bird prefab from the array
        int birdIndex = Random.Range(0, birdPrefabs.Length);
        GameObject birdPrefab = birdPrefabs[birdIndex];

        // generate a random Y position for the bird
        float yPos = Random.Range(minBirdY, maxBirdY);

        // create a new bird game object at the spawner's position
        GameObject newBird = Instantiate(birdPrefab, transform.position, Quaternion.identity) as GameObject;

        newBird.transform.Rotate(new Vector3(0f, -450f, 0f));

        // set the bird's Y position randomly
        Vector3 birdPosition = newBird.transform.position;
        birdPosition.y = yPos;
        newBird.transform.position = birdPosition;

        // set the bird's speed and rotation randomly
        float speedVariation = Random.Range(-1f, 1f) * 0.5f;
        newBird.GetComponent<Rigidbody>().velocity = new Vector3(-birdSpeed + speedVariation, 0, 0);
        newBird.transform.Rotate(new Vector3(0, 0, Random.Range(-30f, 30f)));

        // destroy the bird after a set amount of time
        Destroy(newBird, 10f);
    }
}
