using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject santaPrefab;
    public float santaPeriod;
    public int maxSantas;
    private int cost;
    private GoldParams goldParams;

    void OnMouseDown()
    {
        int count = GameObject.FindGameObjectsWithTag("Santa").Length;
        if (count < maxSantas && goldParams.gold >= cost)
        {
            goldParams.gold -= cost;
            Instantiate(santaPrefab, transform.position, santaPrefab.transform.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cost = santaPrefab.GetComponent<SantaParams>().cost;
        goldParams = GameObject.Find("Gold").GetComponent<GoldParams>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
