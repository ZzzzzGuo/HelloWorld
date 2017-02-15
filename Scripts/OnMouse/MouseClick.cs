using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{

   // public Renderer rend;
    // Use this for initialization
    void Start()
    {
        //rend = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        Debug.Log("Click on the door!");
        GetComponent<Rigidbody>().AddForce(-transform.forward * 500f);
        GetComponent<Rigidbody>().useGravity = true;
    }
    void OnMouseDrag()
    {
        GetComponent<Renderer>().material.color -= Color.white * Time.deltaTime* 0.2f;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
