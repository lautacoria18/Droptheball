using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectLevel : MonoBehaviour
{


    //public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadLevel(string levelToLoad) {

        SceneManager.LoadScene(levelToLoad);

    }

    public void backToMenu() {

        SceneManager.LoadScene("MainMenu");
    }
}
