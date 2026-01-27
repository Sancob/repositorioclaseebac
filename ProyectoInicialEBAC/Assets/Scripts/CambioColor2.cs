using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor2 : MonoBehaviour
{
    GameObject prefab2;

    void Awake()
    {
        prefab2 = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color Color2 = new Color(Random.value, Random.value, Random.value);
        prefab2.GetComponent<MeshRenderer>().material.color = Color2;
    }
}
