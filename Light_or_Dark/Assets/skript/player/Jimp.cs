using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Jimp : MonoBehaviour // - Вместо «PlayerMove» должно быть имя файла скрипта
{

    public bool isGraund;
    public float jumpSpeed = 10f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Jump();
    }

    void Jump()
    {


        if (Input.GetButtonDown("Jump") && isGraund)
        {
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
            rb.linearVelocity += jumpVelocityToAdd;
            isGraund = false;
        }
    }

    void OnCollisionEnter2D()
    {
        isGraund = true;
    }
    
}
    
    