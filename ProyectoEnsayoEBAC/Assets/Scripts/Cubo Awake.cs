using UnityEngine;

public class CuboAwake : MonoBehaviour
{
    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3 (0,0,0), //vertice 0
        new Vector3 (1,0,0), //Vectice 1 
        new Vector3 (1,1,0), //vertice 2
        new Vector3 (0,1,0), //vertice 3 
        new Vector3 (0,1,1), //vertice 4
        new Vector3 (1,1,1), //vertice 5 
        new Vector3 (1,0,1), //vertice 6 
        new Vector3 (0,0,1), //vertice 7

    };

    int[] triangulos = {
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
        0,1,6,

    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        objToSpawn = new GameObject("cubo awake");
        objToSpawn.AddComponent<MeshFilter>();
        var MeshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        MeshFilter.Clear();
        MeshFilter.vertices = vertices;
        MeshFilter.triangles = triangulos;
        MeshFilter.RecalculateNormals();

        objToSpawn.AddComponent<BoxCollider>();
        var boxcollider = objToSpawn.GetComponent<BoxCollider>();
        boxcollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        objToSpawn.AddComponent<MeshRenderer>();
        var meshrenderMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshrenderMaterial.color  = Color.white;

        objToSpawn.transform.position = Vector3.one;

       



    
}
}
