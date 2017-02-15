using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArayTest : MonoBehaviour
{
    public GameObject[] players;
    // Use this for initialization
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("The Player's name is " + players[i].name);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
