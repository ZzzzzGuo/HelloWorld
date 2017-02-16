using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();
        Debug.Log("The number of enemy is " + Enemy.enemyCount);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
