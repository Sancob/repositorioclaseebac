using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploVariablesMod8 : MonoBehaviour
{
    int miEntero = 0;
    int valorInt1 = 0;
    int valorInt2 = 0;
    int miCasteoInt;

    float miFloat = 1.243120583205f;
    float a;
    float b;
    float c;

    public string color = "";
    string miNombreCompleto = "Santiago Cobo Rojas";
    string valorFloat;
    string convertirAInt1 = "2560";
    string convertirAInt2 = "3460";
    string eliminar5Caracteres = "Elimina los 5 primeros caracteres";

    public GameObject cubo1;
    public GameObject cubo2;
    private MeshRenderer meshRenderer;
    private MeshRenderer meshRenderer2;

    // Start is called before the first frame update
    void Start()
    {

        //Operación entre variables flotantes y casteo a entero
        a = 5f;
        b = 2.4f;
        c = a - b;
        miCasteoInt = (int)c;
        Debug.Log(miCasteoInt);

        meshRenderer = cubo1.GetComponent<MeshRenderer>();
        meshRenderer2 = cubo2.GetComponent<MeshRenderer>();


        //Punto 6: Separar el nombre completo en nombre, primer apellido y segundo apellido. Mostrar por consola cada uno de ellos.
        string miNombre = miNombreCompleto.Substring(0, 8);
        string miPrimerApellido = miNombreCompleto.Substring(9, 4);
        string miSegundoApellido = miNombreCompleto.Substring(14, 5);
        string []listaDeNombres = miNombreCompleto.Split(' ');

        Debug.Log($"Nombre: {miNombre}");
        Debug.Log($"Primer Apellido: {miPrimerApellido}");
        Debug.Log($"Segundo Apellido: {miSegundoApellido}");

        //Punto 1 de la segunda parte: Convertir los strings a enteros y sumarlos. Mostrar el resultado por consola.
        if (!int.TryParse(convertirAInt1, out valorInt1))
        {
            Debug.LogError($"No se pudo convertir {convertirAInt1} a int");
        }
        if (!int.TryParse(convertirAInt2, out valorInt2))
        {
            Debug.LogError($"No se pudo convertir {convertirAInt2} a int");
        }

        int resultadoSuma = valorInt1 + valorInt2;

        Debug.Log($"El resultado de la suma es: {resultadoSuma}");


        //Punto 2 de la segunda parte: Mostrar por consola cada uno de los caracteres del nombre completo, pero solo los caracteres que estén en posiciones pares.
        for (int i = 0; i < miNombreCompleto.Length; i += 2)
        {
            Debug.Log(miNombreCompleto[i]);
        }


        //Punto 3 de la segunda parte: Eliminar los 5 primeros caracteres de un string y mostrar el resultado por consola.
        string sin5Caracteres = eliminar5Caracteres.Substring(5);
        Debug.Log($"Sin 5 caracteres: {sin5Caracteres}");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Puntos 1 y 5: Incrementar el valor de un entero y multiplicar por 2 el valor de un flotante. Mostrar por consola los valores de cada uno de ellos y el valor del flotante convertido a string con 4 decimales.
        miEntero++;
        miFloat *= 2f;
        valorFloat = miFloat.ToString("F4");
        Debug.Log ($"mi entero es: {miEntero}");
        Debug.Log($"mi flotante es: {miFloat}");
        Debug.Log($"el Float en String es: {valorFloat}");

        //Punto 3: Determinar si el entero es par o impar y mostrar por consola el resultado. Cambiar el color del cubo1 a blanco si es par y a negro si es impar.
        if (miEntero % 2 == 0)
        {
            Debug.Log($"mi entero: {miEntero} es par");

            meshRenderer.material.color = Color.white;
        }

        else
        {
            Debug.Log($"mi entero: {miEntero} es impar");
            meshRenderer.material.color = Color.black;
        }

        //Punto 4: Usar un String y un Switch para cambiar el color de un cubo (Desde el inspector)
        switch(color.ToLower())
        {
            case "rojo":
                meshRenderer2.material.color = Color.red;
                break;

            case "verde":
                meshRenderer2.material.color = Color.green;
                break;

            case "amarillo":
                meshRenderer2.material.color = Color.yellow;
                break;

            case "azul":
                meshRenderer2.material.color = Color.blue;
                break;

            case "cian":
                meshRenderer2.material.color = Color.cyan;
                break;

            case "negro":
                meshRenderer2.material.color = Color.black;
                break;
        }
    }
}
