using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_04 : MonoBehaviour
{
    //Variables
    public int currentyear = 2022;
    public int birthyear = 2002;
    //Variable to take the substraction
    public int age;
    void Start()
    {
        //Operation
        age = currentyear - birthyear;
        //Message
        Debug.Log($"If we are in the year {currentyear}, and you were born in the year {birthyear}, you are {age} years old!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
