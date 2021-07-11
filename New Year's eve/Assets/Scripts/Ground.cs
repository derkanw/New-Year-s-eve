using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject santaPrefab;
    public float santaPeriod;
    public int maxSantas;

    void OnMouseDown()
    {
        int count = GameObject.FindGameObjectsWithTag("Santa").Length;
        if (count < maxSantas)
            Instantiate(santaPrefab, transform.position, santaPrefab.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
