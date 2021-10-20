using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    float speed = 1f;
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
        if (Input.GetButtonDown("Jump")) { 
            rb.AddForce(new Vector2(0, 200));
            isonthefloor = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sol")
        {
            isonthefloor = true;
        }
    }

}
