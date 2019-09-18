using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public string MainMenu;

    public GameObject thePauseScreen;

    private PlayerController thePlayer;

    private PlayerController thePlayerController;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        thePlayerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //makes it so depending on if the time.timescale = 1 or 0 depends on if it runs pausegame or resume game
        if (Input.GetButtonDown("Pause"))
        {
            if (Time.timeScale == 0f)
            {
                ResumeGame();
            }

            else
            {
                GamePause();
            }
        }
    }
    //makes it so if the escape key is pressed down then the pause screen will be activated and the everything in the world will stop moving, and will pause music
    public void GamePause()
    {
        Time.timeScale = 0;

        thePauseScreen.SetActive(true);
        thePlayer.canMove = false;
        thePlayerController.gameMusic.Pause();        
    }

    public void ResumeGame()
    {
        //makes it so if the user clicks the resume game button when paused then the pausescreen will be deactivated and eveything in the world will be able to move again, and will start playing music again
        thePauseScreen.SetActive(false);
        thePlayer.canMove = true;
        thePlayerController.gameMusic.Play();
        Time.timeScale = 1f;
    }

    //makes it so if the user clicks on this button then they will be taken to the main menu screen with the time scale staying at 1, allowing for no interruptions
    public void QuittoMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(MainMenu);
    }
}
