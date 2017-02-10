using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionPractice : MonoBehaviour {

    // Use this for initialization
    int myInt = 5;
    void Start () {
        // int myInt = 5;
        Debug.Log(MyOwnFunction(myInt));

    }
    int MyOwnFunction(int num)
    {
        int ret;
        ret = num * 2;
        return ret;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
