using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AudioScript : MonoBehaviour
{
    public static AudioClip track1, track2, track3, track4, track5, track6, track7;
    static AudioSource audioSrc;
    //public bool playing;
    private int lastSong;


    // Start is called before the first frame update

    public static AudioScript inst;
    void Awake()
    {
        track1 = Resources.Load<AudioClip>("track1");
        track2 = Resources.Load<AudioClip>("track2");
        track3 = Resources.Load<AudioClip>("track3");
        track4 = Resources.Load<AudioClip>("track4");
        track5 = Resources.Load<AudioClip>("track5");
        track6 = Resources.Load<AudioClip>("track6");
        track7 = Resources.Load<AudioClip>("track7");

        audioSrc = GetComponent<AudioSource>();


        if (AudioScript.inst == null)
        {

            AudioScript.inst = this;

            DontDestroyOnLoad(gameObject);

            //Scene level = SceneManager.GetActiveScene();

            //PlaySongBySceneName(level.name);

            //Debug.Log(level.name);
            //audioSc.Play();
            PlayRandomSong();

        }
        else
        {



            Destroy(gameObject);
        }

        
    }

    void Start() {
        track1 = Resources.Load<AudioClip>("track1");
        track2 = Resources.Load<AudioClip>("track2");
        track3 = Resources.Load<AudioClip>("track3");
        track4 = Resources.Load<AudioClip>("track4");
        track5 = Resources.Load<AudioClip>("track5");
        track6 = Resources.Load<AudioClip>("track6");
        track7 = Resources.Load<AudioClip>("track7");

        audioSrc = GetComponent<AudioSource>();


       
        
    }
    void Update() {

 
    }

    void PlayRandomSong()
    {
        Debug.Log("Llego");
        int randomNumber = Random.Range(1, 7);

        if (randomNumber == lastSong)
        {

            PlayRandomSong();
        }
        else
        {

            switch (randomNumber)
            {

                case 1:

                    Debug.Log("track1");
                    audioSrc.clip =track1 ;
                    lastSong = 1;
                    break;
                case 2:
                    Debug.Log("track2");
                    audioSrc.clip = track2;
                    lastSong = 2;
                    break;
                case 3:
                    Debug.Log("track3");
                    audioSrc.clip = track3;
                    lastSong = 3;
                    break;
                case 4:
                    Debug.Log("track4");
                    audioSrc.clip = track4;
                    lastSong = 4;
                    break;
                case 5:
                    Debug.Log("track5");
                    audioSrc.clip = track5;
                    lastSong = 5;
                    break;
                case 6:
                    Debug.Log("track6");
                    audioSrc.clip = track6;
                    lastSong = 6;
                    break;
                case 7:
                    Debug.Log("track7");
                    audioSrc.clip = track7;
                    lastSong = 7;
                    break;

            }
            audioSrc.Play();
        }
    }

}
