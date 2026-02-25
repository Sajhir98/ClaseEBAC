using UnityEngine;

public class ColorAwakeOR : MonoBehaviour
{
    public ColorUpdate GO1;
    public ColorFixedUpdate GO2;
    public bool resultado2;

    private void Update()
    {
        resultado2 = GO1.variable1 || GO2.variable2;

        if (resultado2)
            GetComponent<MeshRenderer>().material.color = Color.white;
        else
            GetComponent<MeshRenderer>().material.color = Color.black;
    }
    private void Awake()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = c;
    }

}
