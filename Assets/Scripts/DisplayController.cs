using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    private Text text;
    private int score;

    void Start()
    {
        text = GetComponentInChildren<Text>();
        score = 0;

        UpdateText();
    }

    void Update()
    {
        
    }

    private void UpdateText()
    {
        text.text = $"Scores: {score}";
    }
}
