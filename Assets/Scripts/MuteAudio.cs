using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MuteAudio : MonoBehaviour
{


    Sprite soundOff, soundOn;
    // Start is called before the first frame update
    void Start()
    {


        soundOff = Resources.Load<Sprite>("SoundOff");
        soundOn = Resources.Load<Sprite>("SoundOn");


        checkAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkAudio() {


        if (AudioListener.volume == 0)
        {
            gameObject.GetComponent<Image>().sprite = soundOff;
            
        }
        else
        {
            
            gameObject.GetComponent<Image>().sprite = soundOn;
        }
    }

    public void muteAudio() {

        if (AudioListener.volume != 0)
        {
            gameObject.GetComponent<Image>().sprite = soundOff;
            AudioListener.volume = 0;
        }
        else {
            AudioListener.volume = 1;
            gameObject.GetComponent<Image>().sprite = soundOn;
        }
    }
}
