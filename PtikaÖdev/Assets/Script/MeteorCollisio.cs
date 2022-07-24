using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorCollisio : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] GameObject effeck;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == layer)
        {
            Instantiate(effeck, transform.position, Quaternion.identity);
            Destroy(gameObject, .2f);
        }
    }
}
