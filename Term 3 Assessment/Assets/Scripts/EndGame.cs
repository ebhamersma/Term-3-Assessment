using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string SampleScene;

    public string MainMenu;

    public GameObject EndScreen;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void PlayAgainbtn()
    {
        SceneManager.LoadScene(SampleScene);
    }

    private void QuittoMainbtn()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
