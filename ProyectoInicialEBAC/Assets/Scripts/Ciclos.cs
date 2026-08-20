using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
        miArreglo = new int[7];
        string[] diasDeLaSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

        for (int i = 0; i < diasDeLaSemana.Length; i++)
        {
            miArreglo[i] = i + 1;
            //Debug.Log(diasDeLaSemana[i]);
        }
        

        foreach (int i in miArreglo)
        {
            Debug.Log(i);
        }

        foreach (string dia in diasDeLaSemana)
        {
            Debug.Log(dia);
        }

        /*int[,] miMatriz = new int[3, 3] { {1, 2, 3 },{4, 5, 6 },{7, 8, 9 } };
        for (int j = 0; j < miMatriz.GetLength(0); j++)
        {
            for (int k = 0; k < miMatriz.GetLength(1); k++)
            {
                Debug.Log(miMatriz[j, k]);
            }
        }

        int[][] miArregloJagged = new int[][]
        {
            new int[]{1, 2, 3},
            new int[]{4, 5 },
            new int[]{6, 7, 8, 9 }
        };

        miArregloJagged[1] = new int[] { 10, 11, 12 };
        Debug.Log(miArregloJagged[0][1]); //Escribir 2

        for (int x = 0; x < miArregloJagged.Length; x++)
        {
            for (int y = 0; y < miArregloJagged[x].Length; y++)
            {
                Debug.Log(miArregloJagged[x][y]);
            }
        } */

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
