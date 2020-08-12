using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseDefeat : MonoBehaviour
{

    private Transform playerBase;

    // Start is called before the first frame update
    void Start()
    {
        playerBase = GetComponent<Transform>(); // Initialises player base.
    }

    // Update is called once per frame
    void Update()
    {
        if (playerBase.childCount == 0) // Counts how many player bases are left.
            gameOver.isPlayerDead = true; // Game over if all player bases are gone.
    }
}
