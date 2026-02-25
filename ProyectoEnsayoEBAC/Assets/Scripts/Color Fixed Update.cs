using UnityEngine;

public class ColorFixedUpdate : MonoBehaviour
{
    public bool variable2;

    private void FixedUpdate()
    {
        variable2 = !variable2;
        if (variable2)
            GetComponent<MeshRenderer>().material.color = Color.white;
        else
            GetComponent<MeshRenderer>().material.color = Color.black;
    
        // Color c = new Color(Random.value, Random.value, Random.value);
        // GetComponent<MeshRenderer>().material.color = c;
    }

}