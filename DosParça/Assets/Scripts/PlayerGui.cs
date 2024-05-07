using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGui : MonoBehaviour
{
    public float horizontal;
    public float speed = 10, jumpStrengt = 3;
    public Rigidbody2D body;
    bool groundCheck;
    public Transform foot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        groundCheck = Physics2D.OverlapCircle(foot.position, 0.5f);

        if(Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrengt * 100));

        }
    }
}
