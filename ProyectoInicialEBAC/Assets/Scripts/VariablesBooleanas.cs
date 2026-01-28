using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2)&& variable3)
        {
            Debug.Log("La operación 1 es verdadera");
        }

        else if((variable1 || variable2)|| variable3)
        {
            Debug.Log("La operación 2 es falsa");
        }

        if (valor1 <= 5)
        {
            Debug.Log("El valor1 es menor o igual que 5");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
