using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLoader : MonoBehaviour
{
    void Start()
    {
        GameObject.FindObjectOfType<AudioSource>().mute = PlayerPrefs.GetInt("mute") > 0;
    }
}
