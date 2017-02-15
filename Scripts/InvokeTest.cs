using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTest : MonoBehaviour
{
    public GameObject sphere;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Produce", 2, 1);
       // Destroy(sphere, 2f); assign to prefab, this is not gonna work.
    }
    void Produce()
    {
        float x = Random.Range(7f, 11f);
        float z = Random.Range(-22f, -18f);
        Instantiate(sphere, new Vector3(x, -11, z), Quaternion.identity);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
