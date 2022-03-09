using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    private bool starTaken;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Star")
        {
            Debug.Log("Estrella");
            starTaken = true;
            Destroy(col.gameObject);
        }
        else if (col.tag == "LevelWin"){
            Debug.Log("gano");
            if (starTaken)
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
