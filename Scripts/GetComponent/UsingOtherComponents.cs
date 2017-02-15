using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    AnotherScript anotherScript;
    YetAnotherScript yetAnotherScript;
    BoxCollider boxCol;

    // Use this for initialization
    private void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
        //color = otherGameObject.GetComponent<Color>();
    }
    void Start()
    {
        otherGameObject.GetComponent<Renderer>().material.color = Color.blue;
        boxCol.size = new Vector3(3f, 3f, 3f);
        Debug.Log("The Player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + "times");
    }

    // Update is called once per frame
    void Update()
    {
        // boxCol.size = new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime;
        if (Input.GetKeyUp(KeyCode.I))
        {
            otherGameObject.transform.Translate(Vector3.forward * Time.deltaTime* 50f);
        }
    }
}
