using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Convention : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log(transform.position.y);
        //if (transform.position.y <= 100f)
        //{
        //    Debug.Log("I'm about to die!");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to die!");
        }
    }
}
