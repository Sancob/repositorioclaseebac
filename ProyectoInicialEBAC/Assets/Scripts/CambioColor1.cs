using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor1 : MonoBehaviour
{

    private MeshRenderer meshRenderer;

    public bool colorChanged;

    void Awake()
    {
        /*prefab1 = this.gameObject;
        Color Color1 = new Color(Random.value, Random.value, Random.value);
        prefab1.GetComponent<MeshRenderer>().material.color = Color1;*/
    }

    // Start is called before the first frame update
    void Start()
    {
        colorChanged = false;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!colorChanged)
        {
            meshRenderer.material.color = Color.white;
            colorChanged = true;
        }

        else
        {
            meshRenderer.material.color = Color.black;
            colorChanged = false;
        }
    }


}
