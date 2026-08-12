using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor5 : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    //GameObject prefab3;
    public GameObject EsferaAND;
    public GameObject EsferaOR;


    [SerializeField] bool colorChanged;
    [SerializeField] bool ColorGO3;
    [SerializeField] bool ColorGO4;

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

        if (EsferaAND != null)
        {
            CambioColor3 scriptEsferaAND = EsferaAND.GetComponent<CambioColor3>();

            if (scriptEsferaAND != null)
            {
                ColorGO3 = scriptEsferaAND.colorChanged;
            }
        }

        if (EsferaOR != null)
        {
            CambioColor4 scriptEsferaOR = EsferaOR.GetComponent<CambioColor4>();

            if (scriptEsferaOR != null)
            {
                ColorGO4 = scriptEsferaOR.colorChanged;
            }
        }

        if (ColorGO3 || ColorGO4)
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
