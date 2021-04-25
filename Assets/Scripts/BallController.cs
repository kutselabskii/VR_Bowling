using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public BallWeight BallWeight;

    public BallWeightMaterials Materials;

    void Start()
    {
        GetComponent<Renderer>().material = Materials.GetMaterial(BallWeight);
    }

    void Update()
    {
        
    }

}

[System.Serializable]
public struct BallWeightMaterials
{
    public Material FeatherMaterial;
    public Material LightMaterial;
    public Material MediumMaterial;
    public Material HeavyMaterial;
    public Material OverwhelmingMaterial;

    public Material GetMaterial(BallWeight weight)
    {
        switch (weight) {
            case BallWeight.Feather:
                return FeatherMaterial;
            case BallWeight.Light:
                return LightMaterial;
            case BallWeight.Heavy:
                return HeavyMaterial;
            case BallWeight.Overwhelming:
                return OverwhelmingMaterial;
            default:
                return MediumMaterial;
        }
    }
}

public enum BallWeight
{
    Medium,
    Feather,
    Light,
    Heavy,
    Overwhelming
}
