using UnityEngine;

public class CuboOnOffDisable : MonoBehaviour
{
    Vector3[] vertices =
    {
        new Vector3 (0,0,0), //vertice 0
        new Vector3 (1,0,0), //vertice 1
        new Vector3 (1,1,0), //vertice 2
        new Vector3 (0,1,0), //vertice 3
        new Vector3 (0,1,1), //vertice 4
        new Vector3 (1,1,1), //vertice 5 
        new Vector3 (1,0,1), //vertice 6
        new Vector3 (0,0,1), //vertice 7
    };
    int[] triangulos =
    {
        0,2,1,  //cara 1
        0,3,2,
        2,3,4,  //cara 2
        2,4,5,
        1,2,5,  //cara 3
        1,5,6,
        0,7,4,  //cara 4
        0,4,3,
        5,4,7,  //cara 5
        5,7,6,
        0,6,7,  //cara 6
        0,1,6
    };

    private void OnEnable()
    {
        CrearCubo("Cubo_OnEnable");
    }

    private void OnDisable ()
    {
        CrearCubo("Cubo_OnDisable");
    }

    void CrearCubo (string Nombre)
    {
        GameObject objToSpawn = new GameObject(Nombre);

        objToSpawn.AddComponent<MeshFilter>();
        var mesh = objToSpawn.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangulos;
        mesh.RecalculateNormals();

        objToSpawn.AddComponent<MeshRenderer>();
        var mat = objToSpawn.GetComponent<MeshRenderer>().material;
        mat.color = new Color(Random.value, Random.value, Random.value);

        objToSpawn.transform.position = Random.insideUnitSphere;


    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
