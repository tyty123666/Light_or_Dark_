using UnityEngine;

public class maus : MonoBehaviour
{
    public float z;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, z);
    }
}
