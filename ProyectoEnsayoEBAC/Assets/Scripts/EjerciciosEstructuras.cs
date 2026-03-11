using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class EjerciciosEstructuras : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Prueba Ejercicio 1
        List<int> lista = miFuncion(10, 1, 50);
        Debug.Log("Lista Generada");
        foreach (int n in lista)
        {
            Debug.Log(n);
        }

        //Prueba Ejercicio 2 
        int[] arreglo = { 5, 2, 9, 1, 7 };
        int[] ordenado = OrdenarDescendente(arreglo);

        Debug.Log("Arreglo Ordenado Descendene");
        foreach (int n in ordenado)
        {
            Debug.Log(n);
        }

        //prueba ejercicio 3
        List<int> repetidos = new List<int>() { 1, 2, 3, 3, 4, 5, 5, 6 };
        HashSet<int> sinRepetidos = QuitarRepetidos(repetidos);

        Debug.Log("HashSet sin repetidos:");
        foreach (int n in sinRepetidos)
        {
            Debug.Log(n);
        }

        //prueba ejercicio 4
        Stack<string> pila = new Stack<string>();
        pila.Push("Uno");
        pila.Push("Dos");
        pila.Push("Tres");

        PilaAcola(pila);
    }

    //EJERCICIO 1

    public List<int> miFuncion(int tamaño, int rangoInferior, int RangoSuperior)
    {
        List<int> numeros = new List<int>();

        for (int i = 0; i < tamaño; i++)
        {
            int numeroRandom = Random.Range(rangoInferior, RangoSuperior);
            numeros.Add(numeroRandom);
        }
        return numeros;
    }

    //EJERCICIO 2 

    public int[] OrdenarDescendente(int[] arreglo)
    {
        int[] copia = (int[])arreglo.Clone();

        System.Array.Sort(copia);
        System.Array.Reverse(copia);

        return copia;
    }

    //EJERCICIO 3
    public HashSet<int> QuitarRepetidos(List<int> lista)
    {
        HashSet<int> conjunto = new HashSet<int>();

        foreach (int n in lista)
        {
            conjunto.Add(n);
        }

        return conjunto;
    }

    //EJERCICIO 4
    public void PilaAcola(Stack<string> pila)
    {
        Queue<string> cola = new Queue<string>();

        Debug.Log("Contenido de la pila:");

        while (pila.Count > 0)
        {
            string elemento = pila.Peek();
            Debug.Log("peek pila: " + elemento);

            cola.Enqueue(elemento);
            pila.Pop();
        }

        Debug.Log("Contenido de la cola:");
        while (cola.Count > 0)
        {
            string elemento = cola.Peek();
            Debug.Log("Peek cola: " + elemento);

            cola.Dequeue();
        }


    }
}
