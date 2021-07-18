using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardParams : MonoBehaviour
{
    public GameObject santaPrefab, giftPrefab;
    // Start is called before the first frame update
    void Start()
    {
        string[] param = new string[6];
        SantaParams santa = santaPrefab.GetComponent<SantaParams>();
        GiftParams gift = giftPrefab.GetComponent<GiftParams>();
        param[0] = santaPrefab.name;
        param[1] = gift.firePower.ToString();
        param[2] = santa.fireSpeed.ToString();
        param[3] = santa.level.ToString();
        param[4] = santa.cost.ToString();
        param[5] = santa.upgradeCost.ToString();
        FillCard(param);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FillCard(string[] param)
    {
        Transform parent = gameObject.transform.GetChild(0);
        for (int i = 0; i < parent.childCount - 2; ++i)
            parent.transform.GetChild(i).GetComponent<Text>().text += " " + param[i];
        parent.transform.GetChild(parent.childCount - 2).transform.GetChild(0).GetComponent<Text>().text += " " + param[5] + " gold";
    }
}
