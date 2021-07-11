using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildParams : MonoBehaviour
{
    public int dissatisfaction, power;
    public float speed;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Gift 3(Clone)")
            dissatisfaction -= collider.gameObject.GetComponent<GiftParams>().firePower;
        if (collider.name == "house")
        {
            print("Game Over!");
            Destroy(gameObject);
        }
    }

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0) * speed;
    }

    void Update()
    {
        if (dissatisfaction == 0)
            Destroy(gameObject);
    }
}
