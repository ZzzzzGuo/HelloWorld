using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAbilitySystem : MonoBehaviour
{
    private int strength;
    private int speed;
    private int agile;
    private int luck;
    private float itemDropRate;
    private int numFriends;

    public int level;

    public int Strength
    {
        get
        {
            return strength;
        }
        set
        {
            strength = value * 10 + 3;
        }
    }
    public int Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value * 20 + 8;
        }
    }
    public int Luck
    {
        get
        {
            return luck;
        }
        set
        {
            luck = value * 5 + 11;
        }
    }
    public int Agile
    {
        get
        {
            return agile;
        }
        set
        {
            agile = value * 5 + 20;
        }
    }


    public int ItemDropRate
    {
        set
        {
            itemDropRate= value * 10 + 3;
        }
    }

    public int NumFriends
    {
        get
        {
            return numFriends;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
