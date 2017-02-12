using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectLight : MonoBehaviour
{

    public Light light;
    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
        light.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //Manully adjust light intensity.
        if (Input.GetKey(KeyCode.W))
        {
            light.intensity = Mathf.Lerp(light.intensity, 8f, 0.002f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            light.intensity = Mathf.Lerp(light.intensity, 0, 0.02f);
        }
        //Auto ajust light intensity
        //light.intensity = Mathf.Lerp(light.intensity, 0f, 0.002f * Time.deltaTime);
    }
}
