using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject prefab;
    public int firePower;
    public float fireSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(InitGift());
        //Invoke("InitGift", fireSpeed);
    }

    IEnumerator InitGift()
    {
        yield return new WaitForSeconds(fireSpeed);
        float speed = 1f;
        GameObject gift = Instantiate(prefab, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
        giftParams param = gift.GetComponent<giftParams>();
        param.target = this.GetComponent<santa>().target;
        param.power = firePower;
    }
}
