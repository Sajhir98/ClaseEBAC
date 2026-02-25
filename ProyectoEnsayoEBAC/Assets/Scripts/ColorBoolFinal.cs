using UnityEngine;

public class ColorBoolFinal : MonoBehaviour
{
    public ColorAwake GO3;
    public ColorAwakeOR GO4;

    private void Update()
    {
        bool resultadofinal = GO3.resultado1 ||  GO4.resultado2;

        if (resultadofinal)
            GetComponent<MeshRenderer>().material.color = Color.white;
        else
            GetComponent<MeshRenderer>().material.color = Color.black;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    
        
    }

