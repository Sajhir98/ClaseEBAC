using UnityEngine;

public class CuboIntOnOffDisable : MonoBehaviour
{
    public GameObject prefabCube;

    private void OnEnable()
    {
        prefabCube = Resources.Load<GameObject>("Cube");
        GameObject cube = Instantiate(prefabCube);
        cube.transform.position = Random.insideUnitSphere;
        cube.GetComponent<MeshRenderer>().material.color =
            new Color(Random.value, Random.value, Random.value);
    }

    private void OnDisable()
    {
        Destroy(prefabCube);
        GameObject cube = Instantiate(prefabCube);
        cube.transform.position = Random.insideUnitSphere;
        cube.GetComponent<MeshRenderer>().material.color =
            new Color(Random.value, Random.value, Random.value);
    }
}
