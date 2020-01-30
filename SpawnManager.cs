using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Dit maakt een array aan voor het animalPrefabs.
    public GameObject[] animalPrefabs; 

    // Dit maakt een float aan voor de spawn range op de x-as met als waarde 20.
    private float spawnRangeX = 20;

    // Dit maakt een float aan voor de spawn positie op de z-as met als waarde 20.
    private float spawnPosZ = 20;

    // Dit maakt een float aan voor startDelay met als waarde 2.
    private float startDelay = 2;

    // Dit maakt een float aan voor spawnInterval met als waarde 1.5.
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Dit zorgt ervoor dat SpawnRandomAnimal() wordt uitgevoerd met een delay en interval. 
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Dit zorgt ervoor dat de dieren worden gespawned op een random posititie.
    void SpawnRandomAnimal()
    {
            // Dit zorgt ervoor dat er een random dier komt.
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            // Dit zorgt ervoor dat er een random plek is.
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            // Dit zorgt ervoor dat de dieren spawnen.
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
