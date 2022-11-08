using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_01 : MonoBehaviour
{
    //Numbers for the later operations
    public float num1 = 3;
    public float num2 = 6;
    public float num3 = 12;
    //variable for the result
    public float result;
    
    void Start()
    {
        //Operation and results
        result = num1 + num2 + num3;
        Debug.Log(result);

    }

 
    void Update()
    {
        
    }
}
