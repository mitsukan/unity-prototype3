using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    // Start is called before the first frame update
    private float resetOffset = 56.5f;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPosition.x - resetOffset)
        {
            transform.position = startPosition;
        }
    }
}
