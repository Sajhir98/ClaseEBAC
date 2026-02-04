using UnityEngine;

public class ColorAwake : MonoBehaviour
{
    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GetComponent<MeshRenderer>().material.color = c;
    }

}
