﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Is it higher or lower than 500");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = correct");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            Debug.Log(guess);

        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            Debug.Log(guess);

        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The answer is correct.");
        }
    }
}
