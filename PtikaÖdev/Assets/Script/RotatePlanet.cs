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
        if (RotateAround)// güneşin etrafında dönmesini sağlayan kısım
        {
            transform.RotateAround(aroundobj.transform.position, Vector3.up, Speed * Time.deltaTime);
        }
        if (Rotate)// kendi etrafında dönmesini sağlan Method 
        {
            transform.Rotate(Vector3.up*Time.deltaTime*Speed);
        }
    }
    private void OnTriggerEnter(Collider other)// tam bir tur atıldığında tam tur atıldıgını yazan method
    {
        if (other.CompareTag("Period"))
        {
            print(gameObject.name+"ben bir kez dönüş yaptım");
        }
    }
}
