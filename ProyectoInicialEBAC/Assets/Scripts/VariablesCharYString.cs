using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '9';
        int valorEntero = c - '5';
        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola EBAC";
        miCaracter = miString[5];
        int longitud = miString.Length;
        Debug.Log(miCaracter);
        Debug.Log(longitud);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
