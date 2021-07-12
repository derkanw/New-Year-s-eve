using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildParams : MonoBehaviour
{
    public int dissatisfaction, power;
    public float speed;
    public GameObject barPrefab;
    private GameObject bar;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Gift 3(Clone)")
        {
            dissatisfaction -= collider.gameObject.GetComponent<GiftParams>().firePower;
            bar.gameObject.transform.GetChild(0).GetComponent<Slider>().value = dissatisfaction;
        }
        if (collider.name == "house")
        {
            print("Game Over!");
            Destroy(gameObject);
        }
        if (dissatisfaction == 0)
            Destroy(gameObject);
    }

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0) * speed;
        bar = Instantiate(barPrefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
        print(bar.name);
        bar.gameObject.transform.GetChild(0).GetComponent<Slider>().maxValue = dissatisfaction;
        bar.gameObject.transform.GetChild(0).GetComponent<Slider>().value = dissatisfaction;
    }

    void Update()
    {

    }
}
