using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    //for  --> Sabemos cuantas veces se va a ejecutar el ciclo
    //while --> No sabemos cuantas veces se va a ejecutar el ciclo
    //do while --> No sabemos cuantas veces se va a ejecutar el ciclo, pero se ejecuta al menos una vez
    //areglos unidimensionales [0, 1,2,3,4,5,6,7,8,9]
    //arreglos multidimensionales [0, 1, 2]
    //                             [3, 4, 5]
    //                             [6, 7, 8]
    //arreglos jagged [0, 1, 2, 3, 4, 5]
    //                [6, 7, 8]
    //                [9, 10]
    //for each

    int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        int[] miArreglo = new int[5];
        string[] diasDeLaSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

        for (int i = 0; i < diasDeLaSemana.Length; i++)
        {
            Debug.Log(diasDeLaSemana[i]);
        }


        /*for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }*/

        //while (contador < 10)
        //{

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
