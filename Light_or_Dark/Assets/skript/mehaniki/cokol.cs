using UnityEngine;

public class cokol : MonoBehaviour
{
public float sole;
public float sila;
Rigidbody2D _rb;
 public float q = 0;
 public float max_q = 100;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    
   if (Input.GetKeyDown(KeyCode.D))
        {
            Vector2 jumpVelocityToAdd = new Vector2(sila, 0f);
            _rb.linearVelocity += jumpVelocityToAdd;
           
        }
           if (Input.GetKeyDown(KeyCode.A))
        {
            Vector2 jumpVelocityToAdd = new Vector2(-sila, 0f);
            _rb.linearVelocity += jumpVelocityToAdd;
           
        }

   //_rb.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * sole, _rb.linearVelocity.y);
    }
    
}
