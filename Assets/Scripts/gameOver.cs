using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gameOver : MonoBehaviour
{

    public static bool isPlayerDead = false;
    private Text gameOverText;

    void Start()
    {
        gameOverText = GetComponent<Text>(); // Starts game with no 'Game Over' sceenes in place.
        gameOverText.enabled = false;
    }

    void Update()
    {
        if(isPlayerDead)
        {
            Time.timeScale = 0; // Freezes game.
            gameOverText.enabled = true; // Displays 'Game Over' text.
        }
    }
}
