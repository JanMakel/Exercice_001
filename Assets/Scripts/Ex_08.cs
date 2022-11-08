using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_08 : MonoBehaviour
{
    //variables
    public string month;
    void Start()
    {
        //Decision operators with OR again, more intuitive solution for me
        if(month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december")
        {
            Debug.Log($"The month {month} has 31 days");
        }
        else if (month == "september" || month == "june" || month == "november" || month == "april")
        {
            Debug.Log($"The month {month} has 30 days");
        }
        else if (month == "february")
        {
            Debug.Log($"The month {month} has 28 days");
        }
        else
        {
            Debug.Log($"The month {month} doesn't exist at all");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
