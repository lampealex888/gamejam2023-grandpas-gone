using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add me!!

public class Menu : MonoBehaviour
{
    public void OnPlayButton ()
    {
        SceneManager.LoadScene(1);
    }
    public void OnControlsButton()
    {
        SceneManager.LoadScene(8);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnCreditsButton()
    {
        SceneManager.LoadScene(7);
    }
}
