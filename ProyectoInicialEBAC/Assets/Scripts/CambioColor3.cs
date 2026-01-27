using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor3 : MonoBehaviour
{
    GameObject prefab3;

    void Awake()
    {
        prefab3 = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Color Color3 = new Color(Random.value, Random.value, Random.value);
        prefab3.GetComponent<MeshRenderer>().material.color = Color3;
    }
}
