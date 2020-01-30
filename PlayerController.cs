using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Dit maakt een float aan voor de horizontal input.
    public float horizontalInput;

    // Dit maakt een float aan voor speed met als standaard waarde 10.
    public float speed = 10.0f;

    // Dit maakt een float aan voor xRange met als standaard waarde 10.
    public float xRange = 10.0f;

    // Dit zorgt ervoor dat we een prefab kunnen selecteren voor projectilePrefab.
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        // Dit zorgt ervoor dat de speler niet verder kan dan x = -10.
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Dit zorgt ervoor dat de speler niet verder kan dan x = 10.
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Dit zorgt ervoor dat de input wordt gelezen.
        horizontalInput = Input.GetAxis("Horizontal");

        // Dit zorgt ervoor dat de speler beweegt.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Dit zorgt ervoor dat als de speler op Space klinkt hij de projectile schiet.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
