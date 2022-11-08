using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_06 : MonoBehaviour
{
    //Just one variable
    public int dayofweek;
    void Start()
    {
        //4 diferent decision operators just in case
        if(dayofweek <= 5)
        {
            Debug.Log($"Day {dayofweek} doesn't belong to the weekend");
        }
        else if(dayofweek == 6)
        {
            Debug.Log($"Day {dayofweek} belong to the weekend");
        }
        else if (dayofweek == 7)
        {
            Debug.Log($"Day {dayofweek} belong to the weekend");
        }
        else
        {
            Debug.Log($"Day {dayofweek} doesn't belong to a week, week only have 7 days!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
