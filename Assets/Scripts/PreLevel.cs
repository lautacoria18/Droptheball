using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PreLevel : MonoBehaviour
{
    public static bool gameStarted;
    private GameObject ball;
    private Vector3 startPosition;
    private GameObject star;
    private Vector3 starPosition;


    private GameObject textClear, textRestart, textDrop;
    private GameObject buttonClear, buttonRestart, buttonDrop;
    Sprite buttonSprite;
    Font font;



    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
        ball = GameObject.FindWithTag("Player");
        star = GameObject.FindWithTag("Star");
        starPosition = star.transform.position;
        startPosition = ball.transform.position;
        Time.timeScale = 0f;

        ///
        buttonSprite = Resources.Load<Sprite>("BigBlue");
        textClear = GameObject.Find("Clear/Text");
        textRestart = GameObject.Find("Restart/Text");
        textDrop = GameObject.Find("Drop/Text");
        buttonClear = GameObject.Find("Clear");
        buttonRestart = GameObject.Find("Restart");
        buttonDrop = GameObject.Find("Drop");
        font = Resources.Load<Font>("Font");

        textClear.GetComponent<Text>().font = font;
        textDrop.GetComponent<Text>().font = font;
        textRestart.GetComponent<Text>().font = font;

        textClear.GetComponent<Text>().fontSize = 18;
        textDrop.GetComponent<Text>().fontSize = 18;
        textRestart.GetComponent<Text>().fontSize = 18;

        buttonClear.GetComponent<Image>().sprite = buttonSprite;
        buttonDrop.GetComponent<Image>().sprite = buttonSprite;
        buttonRestart.GetComponent<Image>().sprite = buttonSprite;

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
