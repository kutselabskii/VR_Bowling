using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingLineController : MonoBehaviour
{
    private PinController[] pins;
    private BallController[] balls;
    private DisplayController display;

    void Start()
    {
        pins = GetComponentsInChildren<PinController>();
        balls = GetComponentsInChildren<BallController>();
        display = GetComponentInChildren<DisplayController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            ResetPositions();
        }

        if (Input.GetKeyDown(KeyCode.F)) {
            foreach(var pin in pins) {
                pin.ForcePush();
            }
        }

        var score = 0;
        foreach(var pin in pins) {
            if (pin.HaveFallen()) {
                ++score;
                pin.Register();
            }
        }
        
        if (score > 0) {
            display.AddScore(score);
        }
    }

    public void ResetPositions()
    {
        var score = 0;
        foreach(var pin in pins) {
            if (pin.HaveFallen()) {
                ++score;
            }
            pin.ResetPosition();
        }

        foreach(var ball in balls) {
            ball.ResetPosition();
        }

        display.AddScore(score);
    }
}
