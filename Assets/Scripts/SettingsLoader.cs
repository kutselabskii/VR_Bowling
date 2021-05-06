using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLoader : MonoBehaviour
{
    void Start()
    {
        GameObject.FindObjectOfType<AudioSource>().mute = PlayerPrefs.GetInt("mute") > 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            CallSave();
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            CallLoad();
        }
    }

    public void CallSave()
    {
        Save.SaveGame();
    }

    public void CallLoad()
    {
        Save.LoadGame();
    }
}
