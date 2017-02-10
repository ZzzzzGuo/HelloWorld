using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashCups : MonoBehaviour
{

    bool shouldcontinue = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        do { Debug.Log("First Print!"); } while (shouldcontinue = true);
    }
}
