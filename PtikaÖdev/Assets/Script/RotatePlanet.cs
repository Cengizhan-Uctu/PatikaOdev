using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    [SerializeField] GameObject aroundobj;
    [SerializeField] float Speed;
    [SerializeField] bool Rotate=false;
    [SerializeField] bool RotateAround=false;
    private void Update()
    {
        if (RotateAround)
        {
            transform.RotateAround(aroundobj.transform.position, Vector3.up, Speed * Time.deltaTime);
        }
        if (Rotate)
        {
            transform.Rotate(Vector3.up*Time.deltaTime*Speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Period"))
        {
            print(gameObject.name+"ben bir kez dönüş yaptım");
        }
    }
}
