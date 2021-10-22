using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    
    Rigidbody2D rb;
    bool isonthefloor = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isonthefloor) { 
            rb.AddForce(new Vector2(0, 400));
            isonthefloor = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Sol")
        {
            isonthefloor = true;
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0;
        }
    }

}
