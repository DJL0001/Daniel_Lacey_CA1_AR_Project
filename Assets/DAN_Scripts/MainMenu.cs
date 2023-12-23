using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script is from the Youtube video "Unity MAIN MENU 2022 Tutorial | Beginner Friendly" - https://youtu.be/pcyiub1hz20?si=bmD9sZWsRGCFMFpE

// This declares the public variable "MainMenu".
public class MainMenu : MonoBehaviour
{
    // This declares a public method called "Play"
    public void Play()
    {
        // This will load the scene which has an index of plus one more than the current scene's index in the build settings. This means that the game scene will load and the gameplay will begin once the play game button is pressed on the main menu.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // This declares a public method called "Quit".
    public void Quit()
    {
        // This will cause the application to exit once the quit game button is pressed
        Application.Quit();
    }
}
  
