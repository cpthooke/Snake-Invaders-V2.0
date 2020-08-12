using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour
{
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            //PlayerScore.playerscore = 0;
            gameOver.isPlayerDead = false; // Player is 'alive' again.
            Time.timeScale = 1; // Game unfreezes.
            SceneManager.LoadScene("BaseScene");

        }
    }
}
