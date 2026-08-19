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
        string miString = "Hola desde EBAC belles";
        string miSegundoString = miString.Replace('e', 'E');
        string miTercerString = miString.ToUpper();
        string ejemploEscape = "\"";
        string miNombre = "Santiago";
        string misApellidos = "Cobo Rojas";
        string primerApellido = misApellidos.Substring(0, 4);
        string salida = $"Mi nombre es: {miNombre} y mis apellidos son: {misApellidos}";
        ;
        miCaracter = miString[5];
        int longitud = miString.Length;
        Debug.Log(primerApellido);
        Debug.Log(salida);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
