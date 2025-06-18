using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        //ecribir en consola los numeros enteros desde 0 a 4
        for (int i = 0; 1 < 5; i++)
        {
            Debug.Log(i);
        }

        //los numeros enteros entre 10 y 40 inclusive
        for (int i = 10; i <= 40; i++)
        {
            Debug.Log(i);
        }

        //los numeros enteros entre dos nros ingresados por inspector 
        for (int i = num1; i<num2; i++)
        {
            Debug.Log(i);
        }

        //los numeros enteros desde 11 hasta 1 excepto el 3
        for (int i = 11; i > 0 ; i--)
        {
            if(i == 3)
            {
                continue;
            }
            Debug.Log(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
