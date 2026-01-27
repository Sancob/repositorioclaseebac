using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    public static GameObject camara;

    private void Awake()
    {
        camara = this.gameObject;
        camara.name = "Camara Principal";
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(camara.name+ " te saluda desde Colombia");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        Debug.LogError(camara.name+ " ha sido desactivada. Se ha puesto triste...");
    }

    private void OnEnable()
    {
        Debug.LogWarning(camara.name + " ha sido activada. Está feliz!");
    }
}
