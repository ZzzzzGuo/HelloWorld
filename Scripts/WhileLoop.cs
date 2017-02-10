using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour {

    // Use this for initialization
    int _counter = 4;
    void Start ()
    {
        while (_counter > 0)
        {
            Debug.Log("I'm still alive.");
            _counter--;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
