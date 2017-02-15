using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZPlayer : MonoBehaviour
{

    ZAbilitySystem Zabilitysystem = new ZAbilitySystem();
    public int levels = 0;
    public int str;
    public int spd;
    public int agl;
    public int luk;
    public float idr;
    // Use this for initialization

    void Start()
    {
        Debug.Log("Levels = " + levels);
    }

    public void UpGrade(int levels)
    {
        Zabilitysystem.Strength = levels;
        str = Zabilitysystem.Strength;

        Zabilitysystem.Speed = levels;
        spd = Zabilitysystem.Speed;

        Zabilitysystem.Agile = levels;
        agl = Zabilitysystem.Agile;

        Zabilitysystem.Luck = levels;
        luk = Zabilitysystem.Luck;
    }

    // Update is called once per frame


    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            UpGrade(levels);
            Debug.Log("Levels = " + levels);
            Debug.Log("Streng = " + str);
            Debug.Log("spd = " + spd);
            Debug.Log("agl = " + agl);
            Debug.Log("luk = " + luk);
            Debug.Log(" ");
            levels++;
        }
        if (levels == 5)
        {
            levels = 0;
        }
        switch (levels)
        {
            case 1:
                GetComponent<Renderer>().material.color = Color.black;
                break;
            case 2:
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                GetComponent<Renderer>().material.color = Color.cyan;
                break;
            case 4:
                GetComponent<Renderer>().material.color = Color.blue;
                break;
        }
    }
}
