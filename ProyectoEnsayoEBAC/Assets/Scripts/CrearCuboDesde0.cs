using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    GameObject objTospawn;
    Vector3[] vertices = {
        new Vector3 (0,0,0), //vertice0
        new Vector3 (1,0,0), //vertice1
        new Vector3 (1,1,0), //vertice2
        new Vector3 (0,1,0), //vertice3
        new Vector3 (0,1,1), //vertice4
        new Vector3 (1,1,1), //vertice5 
        new Vector3 (1,0,1), //vertice6
        new Vector3 (0,0,1), //vertice7
    };

    int[] triangulos = {
        0,2,1, //cara 1
        0,3,2,
        2,3,4, //cara2
        2,4,5,
        1,2,5, //cara3
        1,5,6,
        0,7,4, //cara4
        0,4,3,
        5,4,7, //cara5
        5,7,6,
        0,6,7, //cara6
        0,1,6

    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objTospawn = new GameObject("Nuestro Primer Cubo");
        objTospawn.AddComponent<MeshFilter>();
        var MeshFilter = objTospawn.GetComponent<MeshFilter>().mesh;
        MeshFilter.Clear();
        MeshFilter.vertices = vertices;
        MeshFilter.triangles = triangulos;
        MeshFilter.Optimize();
        MeshFilter.RecalculateNormals();
        objTospawn.AddComponent<BoxCollider>();
        var boxCollider = objTospawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f );
        objTospawn.AddComponent<MeshRenderer>();
        var MeshRenderMaterial = objTospawn.GetComponent<MeshRenderer>().material;
        MeshRenderMaterial.color = Color.white;
        objTospawn.transform.position = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
