using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ingame : MonoBehaviour
{
    public static bool paused = false;
    public void pause_game()
    {
        if (paused)
        {
            if (collision_detect.game_ended == false)
            {
                Time.timeScale = 1;
                paused = false;
            }
        }
        else
        {
            paused = true;
            Time.timeScale = 0;
        }
    }

    public void restart_game()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        paused = false;
        destroyer.count = 0;
        destroyer.r2 = 370;
        collision_detect.game_ended = false;

    }

}
