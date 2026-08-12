using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor4 : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    //GameObject prefab3;
    public GameObject Capsule;
    public GameObject Cube;


    public bool colorChanged;
    [SerializeField] bool ColorGO1;
    [SerializeField] bool ColorGO2;

    void Awake()
    {
        //prefab3 = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*Color Color3 = new Color(Random.value, Random.value, Random.value);
        prefab3.GetComponent<MeshRenderer>().material.color = Color3;*/

        if (Capsule != null)
        {
            CambioColor1 scriptCapsule = Capsule.GetComponent<CambioColor1>();

            if (scriptCapsule != null)
            {
                ColorGO1 = scriptCapsule.colorChanged;
            }
        }

        if (Cube != null)
        {
            CambioColor1 scriptCube = Cube.GetComponent<CambioColor1>();

            if (scriptCube != null)
            {
                ColorGO2 = scriptCube.colorChanged;
            }
        }

        if (ColorGO1 || ColorGO2)
        {
            colorChanged = true;
        }

        else
        {
            colorChanged = false;
        }

        if (colorChanged)
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.black;
        }
    }
}
