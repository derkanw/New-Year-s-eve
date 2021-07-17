using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameLoop : MonoBehaviour
{
    public int maxChildren, waveCount;
    public float wavePeriod;
    public float distance;
    public GameObject childPrefab, grassPrefab;
    private int width = 10, height = 5;
    private Text wave;

    void Awake()
    {
        for (int i = -width; i < width; ++i)
            for (int j = -height; j < height; ++j)
            {
                GameObject part = Instantiate(grassPrefab, new Vector3(0.5f + i, 0, 0.5f + j), grassPrefab.transform.rotation);
                if (!(i >= -width + 2 && j >= -height + 2 && j < height - 2))
                    Destroy(part.GetComponent<Ground>());
            }
    }
    
    void Start()
    {
        wave = GameObject.Find("Wave").GetComponent<Text>();
        wave.text = "Wave: ";
        StartCoroutine(InitWave());
    }

    void Update()
    {
        
    }

    IEnumerator InitChildren()
    {
        for (int i = 0; i < maxChildren; ++i)
        {
            Instantiate(childPrefab, new Vector3(distance, 0, Random.Range(-4, 3) + 0.5f), childPrefab.transform.rotation);
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
    }

    IEnumerator InitWave()
    {
        for (int i = 0; i < waveCount; ++i)
        {
            StartCoroutine(InitChildren());
            wave.text = "Wave: " + (i + 1).ToString();
            yield return new WaitForSeconds(wavePeriod);
        }
    }
}
