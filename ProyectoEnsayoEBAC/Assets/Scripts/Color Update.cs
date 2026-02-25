using UnityEngine;

public class ColorUpdate : MonoBehaviour
{
    public bool variable1;

    private void FixedUpdate()
    {
        variable1 = !variable1;
        if (variable1)
            GetComponent<MeshRenderer>().material.color = Color.white;
        else
            GetComponent<MeshRenderer>().material.color = Color.black;
    }
    void Update()
    {
        // Color c = new Color(Random.value, Random.value, Random.value);
        // GetComponent<MeshRenderer>().material.color = c;
    }
}
