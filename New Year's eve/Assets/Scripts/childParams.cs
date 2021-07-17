using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildParams : MonoBehaviour
{
    public int dissatisfaction, power;
    public float speed;
    private Slider bar;
    private int cost = 20;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Gift 3(Clone)")
        {
            dissatisfaction -= collider.gameObject.GetComponent<GiftParams>().firePower;
            bar.value = dissatisfaction;
        }
        if (collider.name == "house")
        {
            print("Game Over!");
            Destroy(gameObject);
        }
        if (dissatisfaction == 0)
        {
            GameObject.Find("Gold").GetComponent<GoldParams>().gold += cost;
            Destroy(gameObject);
        }
    }

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0) * speed;
        bar = gameObject.transform.GetChild(2).transform.GetChild(0).GetComponent<Slider>();
        bar.maxValue = dissatisfaction;
        bar.value = dissatisfaction;
    }

    void Update()
    {

    }
}
