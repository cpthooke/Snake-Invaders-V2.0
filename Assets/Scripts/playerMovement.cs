using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float maxBound, minBound;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent <Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal"); // A/D or Arrow keys.

        if (player.position.x < minBound && h < 0)
            h = 0; //If player is at far left, stops player going off screen.
        else if (player.position.x > maxBound && h > 0)
            h = 0;

        player.position += Vector3.right * h * speed;
        

    }
}
