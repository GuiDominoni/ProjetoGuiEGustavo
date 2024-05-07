using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    public Rigidbody2D rb;
    public float speed, jumpForce;
    public bool isGround;
    public Transform foot;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
            
        isGround = Physics2D.OverlapCircle(foot.position, 0.05f);

    }

    // Update is called once per frame
    void Update()
    {

        rb.velocity = Vector2.right * speed;
        if (Input.GetButtonDown("Jump") && isGround)
        
        {

            rb.AddForce(Vector2.up * jumpForce);

        }

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Esp"))
        {


            Destroy(gameObject);


        }

    }
}
