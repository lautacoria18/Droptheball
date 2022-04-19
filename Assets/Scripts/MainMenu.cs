using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject PlayButton, PanelSelectLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playButton()
    {

        PlayButton.SetActive(false);
        PanelSelectLevel.SetActive(true);

    }
    public void backToMenu() {

        PlayButton.SetActive(true);
        PanelSelectLevel.SetActive(false);
    }

    public void loadStage(string stage) {

        SceneManager.LoadScene(stage);
    }


}
