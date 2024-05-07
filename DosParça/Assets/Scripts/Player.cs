using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Rigidbody2D rb;
    public float speed, jumpForce;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = Vector2.right * speed;
        if (Input.GetButtonDown("Jump"))
        
        {

            rb.AddForce(Vector2.up * jumpForce * Time.deltaTime);

        }

    }
}
