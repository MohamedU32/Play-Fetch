using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnRate = 0.5f;
    private float nextSpawn = 0.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;  // delay the dog instantiation
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
