using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{

    public int[] edades;

    // Start is called before the first frame update
    void Start()
    {
        //escribir el primer punto del array 
        Debug.Log(edades[0]);

        //escribir el largo del array 
        Debug.Log(edades.Length);

        // escribir el ultimo elemento del array
        Debug.Log(edades[edades.Length - 1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
