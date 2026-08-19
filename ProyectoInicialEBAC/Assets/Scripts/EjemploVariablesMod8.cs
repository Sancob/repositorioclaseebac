using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploVariablesMod8 : MonoBehaviour
{
    int miEntero = 0;
    float miFloat = 1.243120583205f;
    float a;
    float b;
    float c;
    int miCasteoInt;

    public string color = "";
    string valorFloat;

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
