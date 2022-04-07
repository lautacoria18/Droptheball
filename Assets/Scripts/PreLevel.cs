using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreLevel : MonoBehaviour
{
    public static bool gameStarted;
    private GameObject ball;
    private Vector3 startPosition;
    private GameObject star;
    private Vector3 starPosition;
   

    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
        ball = GameObject.FindWithTag("Player");
        star = GameObject.FindWithTag("Star");
        starPosition = star.transform.position;
        startPosition = ball.transform.position;
        Time.timeScale = 0f;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartPosition() {
        gameStarted = false;
        Time.timeScale = 0f;
        star.SetActive(true);
        star.transform.position = starPosition;
        ball.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 0f, 0f);
        ball.GetComponent<Rigidbody2D>().angularVelocity = 0f;
        ball.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        ball.transform.position = startPosition;


    }

    public void StartGame() {
        gameStarted = true;
        Time.timeScale = 1f;

    }

    public void RestartGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
