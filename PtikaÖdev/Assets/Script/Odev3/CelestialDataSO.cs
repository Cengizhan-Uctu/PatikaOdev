using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CelestialDataSO", menuName = "Scriptable Object/CelestialDataSO", order = 1)]
public abstract class CelestialDataSO : ScriptableObject
{
    public string CelestialName;
    public string CelestialDescription;
    public GameObject CelestialPrefab;

    public override string ToString()
    {
        return string.Format("{0} - {1}", CelestialName, CelestialDescription);
    }
}