using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_05 : MonoBehaviour
{
    //Variables
    public int num1 = 20;
    public int num2 = 16;
    void Start()
    {
        //Decisicon operators
        if(num1 > num2)
        {
            Debug.Log($"{num1} it's bigger than {num2}");
        }
        else
        {
            Debug.Log($"{num1} it's smaller than {num2}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
