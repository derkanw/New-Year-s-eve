using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene("Scenes/GameOver");
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
        bar = gameObject.transform.GetChild(2).transform.GetChild(0).GetComponent<Slider>();
        bar.maxValue = dissatisfaction;
        bar.value = dissatisfaction;
    }

    void Update()
    {

    }
}
