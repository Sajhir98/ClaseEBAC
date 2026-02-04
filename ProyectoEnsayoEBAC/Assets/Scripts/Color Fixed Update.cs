using UnityEngine;

public class ColorFixedUpdate : MonoBehaviour
{
    private void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }

}