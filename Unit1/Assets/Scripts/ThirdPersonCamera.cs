using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{

    public GameObject player;
    // The offset of the camera
    public Vector3 offset = new Vector3(0, 6, -12);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void LateUpdate()
    {
        // Move camera
        transform.position = player.transform.position + offset;
    }
}
