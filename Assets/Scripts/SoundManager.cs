using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager _instance;

    public static SoundManager Instance { get { return _instance; } }

    public AudioSource[] soundsList;

    //Sound Enums
    public enum Sounds
    {
        Music
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        if (!PlayerPrefs.HasKey("SOUND"))
        {
            PlayerPrefs.SetInt("SOUND", 1);
        }
        if (!PlayerPrefs.HasKey("VIBRATION"))
        {
            PlayerPrefs.SetInt("VIBRATION", 1);
        }
    }


    public void playSound(Sounds soundType)
    {
        if (PlayerPrefs.GetInt("SOUND") == 1)
        {
            soundsList[(int)soundType].Play();
        }
    }

    public void stopSound(Sounds soundType)
    {
        soundsList[(int)soundType].Stop();
    }


}
