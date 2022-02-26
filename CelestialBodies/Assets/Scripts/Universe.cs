using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
    public CelestialBody[] celestialBodies;

    // Start is called before the first frame update
    void Start()
    {
        celestialBodies = FindObjectsOfType<CelestialBody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (CelestialBody body in celestialBodies)
        {
            foreach (CelestialBody otherBody in celestialBodies)
            {
                if (!body.Equals(otherBody)) 
                {
                    body.ApplyGravitationalPull(otherBody);
                }
            }
        }
    }
}

public static class UniversalConstants
{
    public static float gravity = -9.8f;
} 