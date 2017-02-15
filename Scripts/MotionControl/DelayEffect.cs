using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayEffect : MonoBehaviour
{

    public float xSpeed = 5f;
    public float zSpeed = 50f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(xDirection* xSpeed * Time.deltaTime, 0, zDirection* zSpeed * Time.deltaTime));
    }
}
