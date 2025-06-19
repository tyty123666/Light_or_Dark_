using UnityEngine;

public class cepi : MonoBehaviour
{
    public float sila;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector2.left * sila);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            rb.AddForce(Vector2.right * sila);
        }
    }
    
}
