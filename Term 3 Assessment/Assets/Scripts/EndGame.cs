using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{    
    public string mainMenu;

    public GameObject gameOverScreen;

    public string sampleScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Makes it so if the player clicks on the button then it will load the appropriate scene
    public void PlayAgain()
    {
        SceneManager.LoadScene(sampleScene);
    }

    public void QuittoMain()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
