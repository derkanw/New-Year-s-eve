using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldParams : MonoBehaviour
{
    //TO DO: добавить свойство с ограничением целостности данных для gold
    public int gold;
    private Text field;

    // Start is called before the first frame update
    void Start()
    {
        field = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        field.text = "Gold: " + gold.ToString();
    }
}
