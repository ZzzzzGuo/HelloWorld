using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int exp;
    Player player = new Player();
    // Use this for initialization
    void Start()
    {
        player.Experience = 5;
        exp = player.Experience;
        Debug.Log("The experience of player is "+ exp);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
