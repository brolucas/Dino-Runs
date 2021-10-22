using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacleZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("touché");
            Destroy(collision.gameObject);
        }
    }
}
