using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25,0,0);
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the obstacle at the given position and rotation.
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
