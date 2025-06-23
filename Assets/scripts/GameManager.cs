using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] carteles;
    public Renderer gameRenderer;
    public int randomCartelIndex;

    // Start is called before the first frame update
    void Start()
    {
        //Invocar la activacion random cada 2 segundos 
        InvokeRepeating(nameof(ActivateRandomElement), 0, 2f);
    }
        
    //funcion que desactiva todos los elementos del array
    void DesactivateAll()
    {
        //For
    }

    //funcion que activa un elemento al azar del array
    //y desactiva todos los demas

    void ActivateRandomElement()
    {
        DesactivateAll();
        //activar elemento al azar
        randomCartelIndex = Random.Range(0, carteles.Length);
        gameRenderer.material.color = carteles[randomCartelIndex];
    }

}
