using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_03 : MonoBehaviour
{
    //Variables
    public int age = 20;
    public string name = "Jan";
    void Start()
    {
        //Message
        Debug.Log($"Hello, {name}! You're {age} years old");
    }

  
    void Update()
    {
        
    }
}
