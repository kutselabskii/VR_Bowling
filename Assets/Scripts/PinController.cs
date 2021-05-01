using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    private Vector3 startingPosition;
    private Quaternion startingRotation;
    private bool scoreSet;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        startingPosition = transform.position;
        startingRotation = transform.rotation;
    }

    void Update()
    {
        
    }

    public void ResetPosition()
    {
        transform.SetPositionAndRotation(startingPosition, startingRotation);
        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
        scoreSet = false;
    }

    public void Register()
    {
        scoreSet = true;
    }

    public bool HaveFallen()
    {
        if (scoreSet) {
            return false;
        }
        return Mathf.Abs(Quaternion.Dot(startingRotation, transform.rotation)) < 0.8;
    }

    public void ForcePush()
    {
        rigidbody.AddForce(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
    }
}
