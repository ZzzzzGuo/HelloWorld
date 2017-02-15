using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{

    // Use this for initialization

    void Start()
    {
        //Vector3 pos = transform.position;
        //pos = new Vector3(0, 2, 0);

        Transform tran = GetComponent<Transform>();
        tran.position = new Vector3(0, 2, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
