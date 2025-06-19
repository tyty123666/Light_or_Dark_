using UnityEngine;

public class EneniSistem : MonoBehaviour
{
    public GameObject i;
    public Vector3 camOffset = new Vector3(0f, 0f, 0f);
    private Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = i.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(camOffset);

        this.transform.LookAt(target);
    }
}
