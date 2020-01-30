using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Dit maakt een float aan voor speed met als standaard waarde 40.
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        // Dit zorgt ervoor dat het voorwerp beweegt.
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
