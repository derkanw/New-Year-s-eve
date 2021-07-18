using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public Canvas UI;
    public void OnUpgradeButton()
    {
        //GoldParams goldParams = GameObject.Find("Gold").GetComponent<GoldParams>();
        //CardParams param = gameObject.GetComponent<CardParams>();
        //SantaParams santa = param.santaPrefab.GetComponent<SantaParams>();
        //if (goldParams.gold < santa.upgradeCost)
        {
            GameObject playerText = new GameObject("Text");
            playerText.layer = 5;
            RectTransform uiPos = playerText.AddComponent<RectTransform>();
            Text uiText = playerText.AddComponent<Text>();
            playerText.transform.SetParent(UI.transform, false);
            uiPos.sizeDelta.Set(Screen.width, Screen.height);
            uiPos.anchoredPosition3D = new Vector3(0, 0, 0);
            uiPos.anchoredPosition = new Vector2(10, 10);
            uiPos.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            uiPos.localPosition.Set(0, 0, 0);
            uiText.supportRichText = true;
            uiText.fontSize = 150;
            uiText.font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
            uiText.alignment = TextAnchor.MiddleCenter;
            uiText.horizontalOverflow = HorizontalWrapMode.Overflow;
            uiText.verticalOverflow = VerticalWrapMode.Overflow;
            uiText.text = "Not enough gold!";
            return;
        }


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
