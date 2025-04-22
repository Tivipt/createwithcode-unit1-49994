using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject FirstPersonCamera;
    public GameObject ThirdPersonCamera;
    // Start is called before the first frame update
    void Start()
    {
        FirstPersonCamera.SetActive(false);
        ThirdPersonCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Switch Camera") & FirstPersonCamera == false)
        {
            FirstPersonCamera.SetActive(true);
            ThirdPersonCamera.SetActive(false);
        }
        else if (Input.GetButtonDown("Switch Camera") & FirstPersonCamera == true)
        {
            FirstPersonCamera.SetActive(false);
            ThirdPersonCamera.SetActive(true);
        }
    }
}
