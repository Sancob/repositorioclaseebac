using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerTarea6 : MonoBehaviour
{
    public GameObject cubePrefab;
    public List<GameObject> listaDeCubos;

    public GameObject SpawnPoint1;
    public GameObject SpawnPoint2;
    public GameObject SpawnPoint3;

    public Material Yellow;
    public Material Pink;
    public Material Blue;

    void Awake()
    {
        listaDeCubos = new List<GameObject>();
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.transform.position = Random.insideUnitSphere + SpawnPoint1.transform.position;
        tempGameObject.GetComponent<MeshRenderer>().material = Yellow;

    }
    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.transform.position = Random.insideUnitSphere + SpawnPoint2.transform.position;
        tempGameObject.GetComponent<MeshRenderer>().material = Blue;
    }

    void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.transform.position = Random.insideUnitSphere + SpawnPoint3.transform.position;
        tempGameObject.GetComponent<MeshRenderer>().material = Pink;
    }

    void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(cubePrefab);
        tempGameObject.transform.position = Random.insideUnitSphere + SpawnPoint3.transform.position;
        tempGameObject.GetComponent<MeshRenderer>().material = Pink;
    }
}
