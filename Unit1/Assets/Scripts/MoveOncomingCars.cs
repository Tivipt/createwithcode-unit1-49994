using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOncomingCars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves the oncoming cars
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }
}
