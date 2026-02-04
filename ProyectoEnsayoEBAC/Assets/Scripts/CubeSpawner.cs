using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factordeEscalamiento;
    public int NumCubos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        NumCubos++;
        GameObject TempGameObject = Instantiate<GameObject>(PrefabCubo);
        TempGameObject.name = "CuboNumero" + NumCubos;
        Color c = new Color(Random.value,Random.value,Random.value);
        TempGameObject.GetComponent<MeshRenderer>().material.color = c;
        TempGameObject.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(TempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach(GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factordeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if(scale <= 0.1)
                {
                objetosParaEliminar.Add(go);

            }
        }

        foreach(GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
