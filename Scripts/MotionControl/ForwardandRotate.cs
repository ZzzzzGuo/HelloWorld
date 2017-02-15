using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardandRotate : MonoBehaviour
{

    // Use this for initialization
    public float moveSpeed = 5.0f;
    public float turnSpeed = 0.0005f;
    public float xSpeed = 5f;
    public float zSpeed = 5f;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("up"))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.Translate(xSpeed * Time.deltaTime, 0, zSpeed * Time.deltaTime);
        }
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        //}
    }
}
