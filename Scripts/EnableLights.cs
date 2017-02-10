using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLights : MonoBehaviour
{

    // Use this for initialization
    private Light pointLight;
    void Start()
    {
        pointLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            pointLight.enabled = !pointLight.enabled;
        }
        //if (Input.GetMouseButtonUp(1))
        //{
        //    gameObject.SetActive(false);
        //}
    }
}
