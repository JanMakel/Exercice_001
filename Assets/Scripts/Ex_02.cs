using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_02 : MonoBehaviour
{
    //Variables for the message
    public string name = "Joan Miquel";
    public string city = "Las vegas";

    void Start()
    {
        //message in console
        Debug.Log($"Hello {name}! Welcome to {city}");
    }

   
    void Update()
    {
        
    }
}
