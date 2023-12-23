using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is a script for pausing the game and having it enter into a menu where you can exit the game to the main menu. It comes from a Youtube video called "Unity PAUSE MENU 2022 Tutorial | Beginner Friendly" - https://www.youtube.com/watch?v=bxKEftSIGiQ 

// This package is necessary so that I can change the scene from the game scene pause menu to the main menu scene
using UnityEngine.SceneManagement;

// This is declaring the public class "PauseMenu"
public class PauseMenu : MonoBehaviour
{
    // This declares a static boolean called "Paused" which is set to false. This is so the game does not start off in a paused state. It will store the current pause state of the game
    public static bool Paused = false;

    // This declares a public variable called "PauseMenuCanvas" which is a GameObject. 
    public GameObject PauseMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        // This sets the game speed to run at 1f which is normal speed
        Time.timeScale = 1f;    
    }

    // Update is called once per frame
    void Update()
    {
       // This is used to check if the "P" key is depressed. The "P" is for paused.
       if(Input.GetKeyDown(KeyCode.P))
       {
        // This checks if the game is already paused. 
        if(Paused)
        {
            // If the game is paused this will cause the game to resume or play
            Play();
        }

        // If the game is not already paused
        else
        {
            // This will cause the game to pause.
            Stop();
        }
       } 
    }

    // This declares a public method called "Stop". This is so the "Stop" method can be called from outside this script. 
    public void Stop()
    {
        // This sets the "PauseMenuCanvas" object to active which will make the pause screen visible when pause is initiated.
        PauseMenuCanvas.SetActive(true);
        // This will set the time scale to 0f which means the game will pause.
        Time.timeScale = 0f;
        // This sets the "Paused" variable to true which means that the game is paused.
        Paused = true;
    }

    // This declares a public method called "Play". This is used to resume the game.
    public void Play()
    {
        // This sets the "PauseMenuCanvas" object to inactive which will make the pause screen invisible. 
        PauseMenuCanvas.SetActive(false);
        // This sets the time scale of the game to 1f which is normal speed.
        Time.timeScale = 1f;
        // This sets the "Paused" variable to false which means that the game is unpaused. 
        Paused = false;
    }

    // This declares the public method "MainMenuButton". This method will load the main menu screen.
    public void MainMenuButton()
    {
        // This will load the scene which has an index of minus one less than the current scene's index in the build settings.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
