using System.Reflection;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Algo Paso");
        Debug.Log("Algo paso");
        Debug.LogWarning("AlgoSalioMedianamenteMal");
        Debug.LogError("AlgoSalio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
