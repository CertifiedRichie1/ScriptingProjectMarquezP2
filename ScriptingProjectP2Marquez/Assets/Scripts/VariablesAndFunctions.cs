using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of the type int and set it to the number 5
    int myInt = 5;


    // Start is called before the first frame update
    void Start()
    {
        myInt = MultipleByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultipleByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}
