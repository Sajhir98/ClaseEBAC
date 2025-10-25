using UnityEngine;

public class ColorUpdate : MonoBehaviour
{
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }
}
