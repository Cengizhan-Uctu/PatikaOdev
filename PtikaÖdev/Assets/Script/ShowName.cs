using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] LayerMask layer;
    [SerializeField] Text PlanetName;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Show();
        }
    }
    void Show()// burada ray cast atıp sahnede objeyi seciyoruz ve onun ismini alıp canvas a yazdırıyoruz
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out RaycastHit hitinfo))
        {
            PlanetName.text = hitinfo.transform.name;
        }
    }
}
