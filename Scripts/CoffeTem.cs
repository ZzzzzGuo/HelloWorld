using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeTem : MonoBehaviour
{
    public float coffeTempOriginal = 80.0f;
    float coolSpeed = 3f;
    float drinkableTemp = 40.0f;
    float coldTemp = 20.0f;
    // Use this for initialization
    void Start()
    {

    }
    void Detect()
    {
        if (coffeTempOriginal > drinkableTemp)
        {
            Debug.Log("Hot.");

        }
        else if (coffeTempOriginal <= coldTemp)
        {
            Debug.Log("Cold.");
        }
        else
        {
            Debug.Log("Good to drink.");
        }
    }
    // Update is called once per frame
    void Update()
    {
        coffeTempOriginal -= Time.deltaTime * coolSpeed;
        if (Input.GetMouseButtonUp(1))
        {
            Detect();
        }

    }
}
