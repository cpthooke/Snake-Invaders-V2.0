using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float maxBound, minBound;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal"); // A/D or Arrow keys.

        if (player.position.x < minBound && h < 0)
            h = 0; //If player is at far left, stops player going off screen.
        else if (player.position.x > maxBound && h > 0)
            h = 0;

        player.position += Vector3.right * h * speed;


    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //shotSpawn.position += new Vector3(0, 1, 0);
            Instantiate(shot, shotSpawn.position + new Vector3(0, 0.5f, 0), shotSpawn.rotation);

        }

    }

}
