using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleControl : MonoBehaviour
{

    float speedScale = 5.0f;
    float xScale;
    float zScale;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xScale = Input.GetAxis("Horizontal") * Time.deltaTime * speedScale;
        zScale = Input.GetAxis("Vertical") * Time.deltaTime * speedScale;
        transform.localScale += new Vector3(xScale, 0, zScale);
    }
}
