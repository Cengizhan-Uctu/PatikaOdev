using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialMovement : MonoBehaviour
{
    public PlanetDataSO planetData;
    public GameObject targetObject;

    private float rotationAngle;

    private void Start()
    {
        targetObject = planetData.parentPlanet;
    }

    void Update()
    {
      
        transform.Rotate(new Vector3(0, planetData.planetSelfRotateSpeed, 0) * Time.deltaTime);

        
        transform.RotateAround(targetObject.transform.position, new Vector3(0, 1, 0), planetData.planetRotateSpeed * Time.deltaTime);

 
        rotationAngle += Time.deltaTime * planetData.planetRotateSpeed;
        if (rotationAngle >= 360)
        {
            Debug.Log($"{planetData.CelestialName} has completed one revolution");
            rotationAngle = 0;
        }
    }
}