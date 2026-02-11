using UnityEngine;

public class Cubo : MonoBehaviour
{
    public GameObject prefabsCube;

    private void Awake()
    {
        prefabsCube = Resources.Load<GameObject>("Cube");
        GameObject TempGameObject = Instantiate<GameObject>(prefabsCube);
        TempGameObject.transform.position = Random.insideUnitSphere;
        TempGameObject.GetComponent<MeshRenderer>().material.color =
             new Color(Random.value, Random.value, Random.value);
        TempGameObject.transform.position = Random.insideUnitSphere;
    }

  
}
