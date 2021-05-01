using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButtonControler : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnPress()
    {
        GetComponentInParent<BowlingLineController>().ResetPositions();
    }
}
