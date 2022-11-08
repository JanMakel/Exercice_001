using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_07 : MonoBehaviour
{
    //Variables
    public string letter;
    void Start()
    {
        //Decision operators with OR
        if(letter == "a" || letter == "e" || letter == "o" || letter == "i" || letter == "u")
        {
            Debug.Log($" Letter {letter} is a vowel");
        }
        else
        {
            Debug.Log($" Letter {letter} is a consonant");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
