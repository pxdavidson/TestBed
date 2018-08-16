using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassingParameterTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
	
    }

    // Called every frame
    void Update()
    {
	DecideGreeting();
    }

    // Process user input to determine greeting given
    void DecideGreeting()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Nice Greeting
            GreetPlayer("you're lovely");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Mean Greeting
            GreetPlayer("fuck you");
        }
    }

    void GreetPlayer(string greeting)
    {
	    Debug.Log(greeting);
    }
}
