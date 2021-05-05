using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettings : MonoBehaviour
{
    private Toggle toggle;

    void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = PlayerPrefs.GetInt("mute", 1) == 0;
    }

    public void ToggleSound()
    {
        PlayerPrefs.SetInt("mute", toggle.isOn ? 0 : 1);
    }
}
