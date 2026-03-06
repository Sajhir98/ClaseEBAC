using UnityEngine;

public class Ejerciciodeciclosyarreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
    }

    void Ejercicio1 ()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];

        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Random.Range(0, 100);
            arr2[i] = Random.Range(0, 100);

            arr3[i] = arr1[i] + arr2[i];

            Debug.Log("arr1[" + i + "] = " + arr1[i] +
                       "arr2[" + i + "] = " + arr2[i] +
                       "arr3[" + i + "] = " + arr3[i]);
        }
    }

    void Ejercicio2()
    {
        string[] palabras = { "Hola", "este", "es", "el", "modulo", "9" };
        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }
        Debug.Log("Oración completa: " + oracion);
    }

    void Ejercicio3()
    {
        int[,] matriz =
        {
            {2,3 },
            {4,5 }
        };

        int[] vector = { 6, 7 };
        int[] resultado = new int[2];

        for (int i = 0; i< 2; i++)
        {
            resultado[i] = 0;

            for(int j = 0; j<2; j++)
            {
                resultado[i] += matriz[i, j] * vector[j];
            }

            Debug.Log("resultado[" + i + "] = " + resultado[i]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
