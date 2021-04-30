using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    void Start()
    {
        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    void Update()
    {
        
    }

    public void ResetPosition()
    {
        transform.SetPositionAndRotation(startingPosition, startingRotation);
    }

    public bool HaveFallen()
    {
        return Mathf.Abs(Quaternion.Dot(startingRotation, transform.rotation)) < 0.8;
    }
}
