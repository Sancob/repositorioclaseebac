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
        a = 5f;
        b = 2.4f;
        c = a - b;
        miCasteoInt = (int)c;
        Debug.Log(miCasteoInt);

        meshRenderer = cubo1.GetComponent<MeshRenderer>();
        meshRenderer2 = cubo2.GetComponent<MeshRenderer>();

        string miNombre = miNombreCompleto.Substring(0, 8);
        string miPrimerApellido = miNombreCompleto.Substring(9, 4);
        string miSegundoApellido = miNombreCompleto.Substring(14, 5);
        string sin5Caracteres = eliminar5Caracteres.Substring(5);
        string []listaDeNombres = miNombreCompleto.Split(' ');


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
        Debug.Log($"Nombre: {miNombre}");
        Debug.Log($"Primer Apellido: {miPrimerApellido}");
        Debug.Log($"Segundo Apellido: {miSegundoApellido}");
        Debug.Log($"Sin 5 caracteres: {sin5Caracteres}");

        for (int i = 0; i < miNombreCompleto.Length; i +=2)
        {
            Debug.Log(miNombreCompleto[i]);
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        miEntero++;
        miFloat *= 2f;
        valorFloat = miFloat.ToString("F4");
        Debug.Log ($"mi entero es: {miEntero}");
        Debug.Log($"mi flotante es: {miFloat}");
        Debug.Log($"el Float en String es: {valorFloat}");
        

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
