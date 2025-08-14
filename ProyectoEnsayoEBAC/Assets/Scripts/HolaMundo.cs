using System.Reflection;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;
        print("Algo Paso");
        Debug.Log("Algo paso");
        Debug.LogWarning("AlgoSalioMedianamenteMal");
        Debug.LogError("AlgoSalio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola Desde Update");
    }
    private void FixedUpdate()
    {
        Debug.Log("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El Objeto ha sido Habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido inhabilitado");
    }
}
