using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Ejericio : MonoBehaviour
{
    int min = 1;
    int max = 9;

    // Start is called before the first frame update
    void Start()
    {
        //Punto #1: Arreglos Unidimensionales llenados aleatoriamente con un tercer arregló que suma los resultados de los arreglos anteriores

        int[] ArregloDeNumeros1 = new int[15];

        for (int i = 0; i < ArregloDeNumeros1.Length; i++)
        {
            int numeroRandom = Random.Range(min, max + 1);

            ArregloDeNumeros1[i] = numeroRandom;

            Debug.Log($"La posición {i} en el primer arreglo guardó el valor {ArregloDeNumeros1[i]}");
        }

        int[] ArregloDeNumeros2 = new int[15];

        for (int i = 0; i < ArregloDeNumeros2.Length; i++)
        {
            int numeroRandom = Random.Range(min, max + 1);

            ArregloDeNumeros2[i] = numeroRandom;

            Debug.Log($"La posición {i} en el segundo arreglo guardó el valor {ArregloDeNumeros2[i]}");
        }

        int[] ArregloDeNumeros3 = new int[15];

        for (int i = 0; i < ArregloDeNumeros3.Length; i++)
        {
            int suma = ArregloDeNumeros1[i] + ArregloDeNumeros2[i];

            ArregloDeNumeros3[i] = suma;

            Debug.Log($"La suma de {ArregloDeNumeros1[i]} + {ArregloDeNumeros2[i]} es: {ArregloDeNumeros3[i]}");
        }

        //Punto#2: Arreglo de Strings concatenados en una oración

        string[] ArregloDeStrings = new string[5] { "Hola", "EBAC,", "te", "saluda", "Santiago"};

        string Oracion = "";

        foreach (string palabra in ArregloDeStrings)
        {
            Oracion += palabra + " ";
        }

        Debug.Log($"La oración completa es: {Oracion}");

        //Punto #3: Multiplicación de arreglo Bidimensional por arreglo Unidimensional

        int[,] ArregloBidimensional = new int[2, 3] { { 4, 7, 2 }, { 3, 6, 5 } };
        int[] ArregloUnidimensional = new int[3] { 2, 4, 3 };
        int[] resultado = new int[2];
        

        for (int i =0; i < ArregloBidimensional.GetLength(0); i++)
        {
            int sumaDeFila = 0;

            for (int j = 0; j < ArregloBidimensional.GetLength(1); j++)
            {
                int multiplicacion = ArregloBidimensional[i, j] * ArregloUnidimensional[j];
                Debug.Log($"La multiplicación de {ArregloBidimensional[i, j]} * {ArregloUnidimensional[j]} es: {multiplicacion}");
                sumaDeFila = sumaDeFila + multiplicacion;
            }

            resultado[i] = sumaDeFila;
        }

        Debug.Log($"El resultado es {resultado[0]}, {resultado[1]}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
