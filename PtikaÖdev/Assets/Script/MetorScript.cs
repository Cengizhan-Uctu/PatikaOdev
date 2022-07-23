using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MetorScript : MonoBehaviour
{
    [SerializeField] GameObject Meteor;
    [SerializeField] GameObject[] Planets;
    [SerializeField] float meteorTime;
    private int RandomTime;
    void Start()
    {
        RandomTime = 1;
        StartCoroutine(MeteorSpawn());
    }
    IEnumerator MeteorSpawn () 
    {
        RandomTime = Random.Range(0, 4);
        int randomPosx = Random.Range(0, 100);
        int randomPosy = Random.Range(0, 40);
        int randomPosz = Random.Range(0, 100);
        int randomPlanet = Random.Range(0, Planets.Length);
        Vector3 newPosMeteor = new Vector3(randomPosx, randomPosy, randomPosz);
        GameObject newMeteor= Instantiate(Meteor, newPosMeteor, Quaternion.identity);
        newMeteor.transform.DOMove(Planets[randomPlanet].transform.position, meteorTime);
        yield return new WaitForSeconds(RandomTime);
    }
}
