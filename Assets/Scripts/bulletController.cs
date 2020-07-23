using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate() //Updates from speed, not frame. 
    {
        bullet.position += Vector3.up * speed; //Upward directions.

        if (bullet.position.y >= 5.3)
            Destroy(gameObject); //Destroys bullet off screen.
                
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            //Increase player score later. @15:30
        }
        else if (other.tag == "Base")
            Destroy(gameObject);
    }
}
