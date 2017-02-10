using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhile : MonoBehaviour {


    // Use this for initialization
    //bool shouldContinue = true;
    void Start()
    {
        bool shouldContinue = true;
        do
        {
            Debug.Log("This should continue!");
        } while (shouldContinue == false);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
