using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftParams : MonoBehaviour
{
    public int firePower;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name != "mainSanta")
            Destroy(gameObject);
    }

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x >= 10)
            Destroy(gameObject);
    }
}
