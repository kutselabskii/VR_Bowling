using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayController : MonoBehaviour
{
    private Text text;
    public int Score;

    void Start()
    {
        text = GetComponentInChildren<Text>();
        Score = 0;

        UpdateText();
    }

    void Update()
    {
        
    }

    public void SetScore(int amount)
    {
        Score = amount;
        UpdateText();
    }

    public void AddScore(int amount)
    {
        Score += amount;
        UpdateText();
    }

    private void UpdateText()
    {
        text.text = $"Scores: {Score}";
    }
}
