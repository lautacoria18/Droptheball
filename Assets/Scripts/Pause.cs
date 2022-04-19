using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{
    public static bool isPaused;
    public GameObject panelPause;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PauseGame() {


        panelPause.SetActive(true);
        Time.timeScale = 0f;

    }

    public void ResumeGame() {


        if (PreLevel.gameStarted)
        {
            Time.timeScale = 1f;
        }
        else {

            Time.timeScale = 0f;
        }
        panelPause.SetActive(false);
        

    }

    public void LoadSelectLevel(string scene) {

        SceneManager.LoadScene(scene);
    }

    public void MainMenu() {

        SceneManager.LoadScene("MainMenu");
    }

    

}
