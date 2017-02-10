using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEach : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        int[] str = new int[4];
        str[0] = 5;
        str[1] = 6;
        str[2] = 2;
        str[3] = 8;
        foreach (int item in str)
        {
            Debug.Log(item);
           // print(str);
        }
        //string[] strings = new string[2];
        //strings[0] = "First string";
        //strings[1] = "Second string";

        //foreach (string item in strings)
        //{
        //    print(item);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
