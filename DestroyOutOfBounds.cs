using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Dit maakt een float aan voor topbound met als waarde 30.
    private float topBound = 30;

    // Dit maakt een float aan voor lowerbound met als waarde -10.
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        // Dit zorgt ervoor dat als de positie van het object groter dan topbound is het wordt verwijderd.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // Dit zorgt ervoor dat als de positie van het object lager dan lowerbound is het wordt verwijderd en laat een game over tekst verschijnen.
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
