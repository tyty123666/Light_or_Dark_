using UnityEngine;

public class cokol : MonoBehaviour
{
    public bool i = false;
    public float x;
    public float y;
    public float z;
    public float z1;

    private Transform cokol11;
    public GameObject collider0;
     public GameObject collider1;
    public GameObject Player;
    private bool Key_Code = false;
    public GameObject obvodka;
    public bool q1 = false;
    public float sole;
    public float sila;
    Rigidbody2D _rb;
    public float q = 0;
    public float max_q = 100;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        obvodka.SetActive(false);
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    bool w = false;
    if (Input.GetKeyDown(KeyCode.E))
            {
                if (i == true)
                {
                    i = false;
                    // Player.transform.position = cokol11.TransformPoint(x, y, z1);
                }
                
}
        cokol11 = GameObject.Find("cokol").transform;
        if (i)
        {
w = true;
            Player.transform.position = cokol11.TransformPoint(x, y, z);
            collider0.SetActive(false);
            collider1.SetActive(false);
        }
        
        else
        {

        if (w == true)
        {
            Player.transform.position = cokol11.TransformPoint(x, y, -7);
        }
            w = false;
        


                    collider0.SetActive(true);
            collider1.SetActive(true);
           
        }
      
           
          
        
                    
if (Key_Code)
        {
            
                if (i == false)
                {
                    i = true;
                }
                //Player.transform.position = cokol11.TransformPoint(0, 0, 0);

            
        }
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Key_Code = true;
            q1 = true;
            obvodka.SetActive(true);
            
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            Key_Code = false;
            q1 = true;
            obvodka.SetActive(false);
        }
    }
}
