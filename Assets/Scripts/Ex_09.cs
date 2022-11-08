using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_09 : MonoBehaviour
{
    //Variables (Note - In the ex 9 it's written to put only 2 variables but I though this is the most conforable way to do it :s)
    public int candy;
    public int people;
    public int candyforperson;
    public int candyleft;
    void Start()
    {
        //Operations
        candyforperson = candy / people;
        candyleft = candy % people;
        //message
        Debug.Log($"There are {candyforperson} candies for person, and there are {candyleft} candies left");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
