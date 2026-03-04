using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesModulo8 : MonoBehaviour
{
    public int contadorEntero = 0;
    public float multiplicadorFloat = 1f;
    public float numeroA = 5.7f;
    public float numeroB = 2.3f;
    public int resultadoEntero;
    public string palabraColor = "rojo";
    public float numeroDecimal = 3.14159265f;
    public string numeroConvertido;
    public string nombreCompleto = "Allan Sajhir Armuelles Sencion";
    public string parte1;
    public string parte2;
    public string parte3;
    public List<string> listaNombre;
    public string numeroTexto1 = "1500";
    public string numeroTexto2 = "3200";
    public string frase = "Hola Mundo";
    public string oracion = "este es un ejemplo de texto";
    void Start()
    {

        //split manual
        parte1 = nombreCompleto.Substring(0, 5);
        parte2 = nombreCompleto.Substring(6, 7);
        parte3 = nombreCompleto.Substring(13);

        //split automatico
        listaNombre = new List<string>(nombreCompleto.Split(' '));

        Debug.Log("Substring 1: " + parte1);
        Debug.Log("Substring 2: " + parte2);
        Debug.Log("Substring 3: " + parte3);

        foreach (string parte in listaNombre)
        {
            Debug.Log("Split: " + parte);
        }

        int numero1;
        int numero2;

        if (int.TryParse(numeroTexto1, out numero1) && int.TryParse(numeroTexto2, out numero2))
        {
            int suma = numero1 + numero2;
            Debug.Log("Resultado suma TryParse:" + suma);
        }
        else
        {
            Debug.Log("Error al convertir los strings.");
        }

        for (int i = 0; i < frase.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("caracter en índice par: " + frase[i]);
            }
        }

        string nuevaOracion = oracion.Substring(5);
        Debug.Log("Oracion sin primeros 5 caracteres: " + nuevaOracion);
    }

    // Update is called once per frame
    void Update()
    {
        contadorEntero++;
        Debug.Log("entero: " + contadorEntero);
        Debug.Log("Float multiplicado: " + multiplicadorFloat);
        resultadoEntero = (int)(numeroA * numeroB);
        Debug.Log("Resultado casteado a int: " + resultadoEntero);
        switch (palabraColor)
        {
            case "rojo":
                GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "verde":
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case "azul":
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            default:
                GetComponent<MeshRenderer>().material.color = Color.white;
                break;
                Debug.Log("Color seleccionado: " + palabraColor);
        }
        numeroConvertido = numeroDecimal.ToString("F4");
        Debug.Log("Float con 4 decimales:" + numeroConvertido);
    }

    void FixedUpdate()
    {
        multiplicadorFloat *= 1.01f;
        if (contadorEntero % 2 == 0)
            GetComponent<MeshRenderer>().material.color = Color.blue;
        else
            GetComponent<MeshRenderer>().material.color = Color.red;

        if (contadorEntero % 2 == 0)
        {
            Debug.Log("Es Par");
        }
        else
        {
            Debug.Log("Es Impar");
        }
    }
}
