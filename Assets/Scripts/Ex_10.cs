using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_10 : MonoBehaviour
{
    //Variable
    public int tablenum = 2;

    void Start()
    {
        //Messages
        Debug.Log($"{tablenum} x 1 = {tablenum * 1}");
        Debug.Log($"{tablenum} x 2 = {tablenum * 2}");
        Debug.Log($"{tablenum} x 3 = {tablenum * 3}");
        Debug.Log($"{tablenum} x 4 = {tablenum * 4}");
        Debug.Log($"{tablenum} x 5 = {tablenum * 5}");
        Debug.Log($"{tablenum} x 6 = {tablenum * 6}");
        Debug.Log($"{tablenum} x 7 = {tablenum * 7}");
        Debug.Log($"{tablenum} x 8 = {tablenum * 8}");
        Debug.Log($"{tablenum} x 9 = {tablenum * 9}");
        Debug.Log($"{tablenum} x 10 = {tablenum * 10}");
        //There is another way to do it(?) 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
