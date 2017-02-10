using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    // Use this for initialization
    public Light light123;
         
   // public Renderer abc123 = Renderer.material.color.black;
    void Start()
    {
        light123 =  GetComponent<Light>();
        light123.intensity = 0f;
        GetComponent<Renderer>().material.color = Color.black;
        
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetMouseButtonUp(0))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetMouseButtonUp(2))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        light123.intensity = Mathf.Lerp(light123.intensity, 8f, 0.0005f * Time.deltaTime);
    }
}
