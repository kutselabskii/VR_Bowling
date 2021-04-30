using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingLineController : MonoBehaviour
{
    private PinController[] pins;
    private BallController[] balls;

    void Start()
    {
        pins = GetComponentsInChildren<PinController>();
        balls = GetComponentsInChildren<BallController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            ResetPositions();
        }
    }

    private void ResetPositions()
    {
        foreach(var pin in pins) {
            pin.ResetPosition();
        }

        foreach(var ball in balls) {
            ball.ResetPosition();
        }
    }
}
