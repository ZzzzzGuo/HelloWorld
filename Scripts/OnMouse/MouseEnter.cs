using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEnter : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnMouseOver()
    {
        GetComponent<Renderer>().material.color -= new Color(0.1f, 0, 0) * Time.deltaTime;
    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
