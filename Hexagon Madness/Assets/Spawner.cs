using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject hexagonPrefab;

    public bool finDelJuego = false;

    private float nextTimeToSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void finalizaElJuego()
    {
        finDelJuego = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextTimeToSpawn && !finDelJuego)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
